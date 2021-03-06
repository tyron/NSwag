﻿using NJsonSchema;
using NJsonSchema.CodeGeneration;
using NSwag.CodeGeneration.TypeScript.Models;

namespace NSwag.CodeGeneration.TypeScript.Templates
{
    internal partial class Angular2ClientTemplate : ITemplate
    {
        public Angular2ClientTemplate(TypeScriptClientTemplateModel model)
        {
            Model = model;
        }

        public TypeScriptClientTemplateModel Model { get; }
        
        public string Render()
        {
            return ConversionUtilities.TrimWhiteSpaces(TransformText());
        }
    }
}
