using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;

namespace Blazoring.JsonEditor
{
    public class JsonItem
    {
        [RequiredIf(nameof(JsonItem.ValueKind), JsonValueKind.Undefined, JsonValueKind.Number, JsonValueKind.String, JsonValueKind.Object, JsonValueKind.Array, JsonValueKind.True)]
        public string? PropertyName { get; set; }

        [RequiredIf(nameof(JsonItem.ValueKind), JsonValueKind.String, JsonValueKind.Array, JsonValueKind.False, JsonValueKind.Null, JsonValueKind.True)]
        public string? Value { get; set; }

        [RequiredIf(nameof(JsonItem.ValueKind), JsonValueKind.Number)]
        public double? NumericValue { get; set; }

        //[RequiredIf(nameof(JsonItem.Value), JsonValueKind.True)]
        //public bool? BooleanValue { get; set; }

        public JsonValueKind ValueKind { get; set; }

    }
}
