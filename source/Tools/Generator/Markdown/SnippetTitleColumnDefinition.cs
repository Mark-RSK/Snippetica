﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Snippets.CodeGeneration.Markdown
{
    internal class SnippetTitleColumnDefinition : ColumnDefinition
    {
        public override string Title
        {
            get { return "Title"; }
        }

        public override string GetValue(object value)
        {
            var snippet = (Snippet)value;

            return MarkdownHelper.Escape(snippet.GetTitleWithoutShortcut());
        }
    }
}
