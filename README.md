# Blazoring.JsonEditor
Json editor for Blazor apps. This editor was created and tested on WebAssembly Blazor app. It is not known how well it works in Server-side Blazor.

## Json Editor tool

* To install the package run following command:

**`Install-Package Blazoring.JsonEditor`**
or search **Blazoring.JsonEditor** in Nuget gallery.

This will install Blazoring.JsonEditor in your project. You also need to add in **_imports.razor**:
```html
@using Blazoring.JsonEditor
```
Also, you need to add javascript file in index.html file:

```html
<script src="_content/Blazoring.JsonEditor/Blazoring.JsonEditor.js"></script>
```
For icons suppor JsonEditor uses Font-Awesome icons library. You need to add link to index.html file:
```html
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.12.0/css/all.css">
```

### Using in code:

```html
<EditForm Model="MyJsonValue">
    <JsonEditor @bind-Value="MyJsonValue.JsonValue" FieldName="@nameof(JsonTestModel.JsonValue)" 
                ValidationFor="@(() => MyJsonValue.JsonValue)"></JsonEditor>

</EditForm>
```

Blazoring.JsonEditor doesn't work without EditForm. Also, validation is required.

You can see [live sample here](https://peaceful-golick-f36338.netlify.com/)
