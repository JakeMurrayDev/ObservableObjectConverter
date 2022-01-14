using ObservableObjectConverter.Extensions;

namespace ObservableObjectConverter
{
    public partial class MainForm : Form
    {
        const string TabSpace = "\u0020\u0020\u0020\u0020"; //Four spaces

        private List<string> _backingFields;
        private List<string> _observables;

        public MainForm()
        {
            InitializeComponent();
            InitializeSetterComboBox();
        }

        private void InitializeSetterComboBox()
        {
            string[] modifiers = new string[]
            {
                "public",
                "private",
                "init"
            };
            setterComboBox.Items.AddRange(modifiers);
        }

        private string GetSetterModifier()
        {
            return setterComboBox.SelectedItem switch
            {
                "public" => "set",
                "private" => "private set",
                "init" => "init",
                _ => "set"
            };
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            _backingFields = new();
            _observables = new();
            GetObservableProperties();
            ApplyObservableProperties();
        }

        private void GetObservableProperties()
        {
            var properties = propRichTxtBox.Text.Trim().Split(TabSpace);
            for (int i = 0; i < properties.Length; i++)
            {
                var property = properties[i];
                var isAttribute = property.Contains('[') && property.Contains("]");
                if (string.IsNullOrWhiteSpace(property) || isAttribute)
                {
                    continue;
                }

                var propertyDetails = properties[i].Trim().Split('\u007B'); //Separate by '{'
                var modifierTypeName = propertyDetails[0].Trim().Split('\u0020');
                var propertyType = modifierTypeName[1];
                var propertyName = modifierTypeName[2];

                var backingFieldName = $"_{propertyName.ToCamelCase()}";
                var backingField = $"private {propertyType} {backingFieldName};";
                _backingFields.Add(backingField);

                var observableProperty = property.Replace("get;", $"{Environment.NewLine}get => {backingFieldName};{Environment.NewLine}")
                    .Replace("set;", $"{GetSetterModifier()} => SetProperty(ref {backingFieldName}, value, nameof({propertyName}));{Environment.NewLine}");
                _observables.Add(observableProperty);
            }
        }

        private void ApplyObservableProperties()
        {
            observableRichTxtBox.Text += $"//Backing Fields{Environment.NewLine}";
            foreach (var backingField in _backingFields)
            {
                observableRichTxtBox.Text += $"{backingField}{Environment.NewLine}";
            }

            observableRichTxtBox.Text += $"{Environment.NewLine}//Properties{Environment.NewLine}";

            foreach (var observableProperty in _observables)
            {
                observableRichTxtBox.Text += $"{observableProperty}{Environment.NewLine}";
            }
        }
    }
}