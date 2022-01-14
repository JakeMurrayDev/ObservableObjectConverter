# Observable Object Converter
A winform app that converts properties into observable objects.<br /><br />
I made this because I'm too lazy writing backing fields and SetProperty on setters.<br />
Btw this for people who use [Microsoft.Toolkit.Mvvm](https://www.nuget.org/packages/Microsoft.Toolkit.Mvvm/) and this is the [Docs.](https://docs.microsoft.com/en-us/windows/communitytoolkit/mvvm/introduction)
<br />

Here's how it looks:<br />
![OOC Form](https://i.imgur.com/OhpbidK.png)<br />
Make sure each properties has tab spaces (four spaces) between. It's auto on VS once you copy your properties unless you changed the settings.<br />
It'll ignore attributes but won't add it back on result.<br />

Setter Modifiers:<br />
- Public (set)
- Private (private set)
- Init (init instead of set)

Result in VS:<br />
![Result in VS](https://i.imgur.com/UHAfasB.png)<br />

To be used for observable objects (fancy name for INotifyPropertyChanged):<br />
![ViewModel](https://i.imgur.com/rdqVpYg.png)<br />

Btw you can't resize the form as I am not familiar with winforms.<br />
I tried tinkering with anchors but the rich text box just gets deformed when maximized.
