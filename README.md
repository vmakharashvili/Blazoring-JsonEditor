# Blazoring-JsonEditor
Json file editor for Blazor apps

## JsonFile Editor tool

* To install the package run following command:

**`Install-Package Blazoring.JsonEditor`**

### Using in code:

```html
<EditForm Model="MyJsonValue">
    <JsonEditor @bind-Value="MyJsonValue.JsonValue" FieldName="@nameof(JsonTestModel.JsonValue)" 
                ValidationFor="@(() => MyJsonValue.JsonValue)"></JsonEditor>

</EditForm>
```

Here EditForm is **required** to bind JsonEditor to your model in blazor.
