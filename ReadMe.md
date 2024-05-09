# CollectionView SelectedItem Binding Issue with .Net 9 Preview 3

This project shows the problem with compiled bindings with collectionview selectedItem with .Net 9 Preview 3

Just do a 
```
dotnet build
```
and you will see the following error
```
XamlC error XFC0045: Binding: Property "SelectedItem" not found on "mauidotnet9pre3_collectionview.MainPageViewModel".
```


You can change to dotnet 9 preview 2 by changing the global.json file to
```
{
  "sdk": {
	"version": "9.0.100-preview.2.24157.14",
	"rollForward": "disable"
  }
}
```
Make sure to delete obj and bin folders before building the project if you switch between dotnet 9 preview 2 and 3.


* It works fine with .net 9 preview 3 sdk (9.0.100-preview.3.24204.13) targeting dotnet 8.
* It works fine with .net 9 preview 2 sdk (9.0.100-preview.2.24157.14) targeting dotnet 9.
* It works fine with .net 8 sdk (8.0.204) targeting dotnet 8.