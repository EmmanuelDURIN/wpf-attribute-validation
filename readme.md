**This is a simple WPF sample that makes validation based on Annotations.**

WPF makes a good job of providing data binding between business objets/Viewmodel Plain Old C# Objects

There are many ways to validate in WPF : ValidationRules usable in XAML, IDataErrorInfo, ....

The ValidatorBase class provided in the sample helps providing errors to the Graphical User Interface based upon Data Annotations

**Just make the inheritance relation and add the attributes !**

For instance :

```csharp
    public class Contact : ValidatorBase
    {
      [Required(ErrorMessage = " Name is required.")]
      [StringLength(50, ErrorMessage = "No more than 50 characters")]
      [Display(Name = "Name")]
      public string Name { get; set; }
	}
```
	
	

	
	