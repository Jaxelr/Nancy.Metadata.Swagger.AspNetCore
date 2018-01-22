﻿using System;
using System.Collections.Generic;
using NJsonSchema;

namespace Nancy.Metadata.Swagger.Core
{
    public class TypeNameGenerator : ITypeNameGenerator, ISchemaNameGenerator
    {
        public string Generate(Type type)
        {
            return type.FullName;
        }

        public string Generate(JsonSchema4 schema, string typeNameHint)
        {
            return typeNameHint;
        }

        public string Generate(JsonSchema4 schema, string typeNameHint, IEnumerable<string> reservedTypeNames)
        {
            return typeNameHint;
        }
    }
}