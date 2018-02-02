﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.Mvc.Razor.TagHelpers
{
    /// <summary>
    /// A <see cref="TagHelperComponentTagHelper"/> targeting the &lt;head&gt; HTML element.
    /// </summary>
    [HtmlTargetElement("head")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class HeadTagHelper : TagHelperComponentTagHelper
    {
        /// <summary>
        /// Creates a new <see cref="HeadTagHelper"/>.
        /// </summary>
        /// <param name="manager">The <see cref="ITagHelperComponentManager"/> which contains the collection
        /// of <see cref="ITagHelperComponent"/>s.</param>
        /// <param name="contextInitializer">The <see cref="ITagHelperComponentContextInitializer"/> initializes
        /// <see cref="ViewContext"/> for the <see cref="ITagHelperComponent"/>.</param>
        /// <param name="loggerFactory">The <see cref="ILoggerFactory"/>.</param>
        public HeadTagHelper(ITagHelperComponentManager manager,
            ITagHelperComponentContextInitializer contextInitializer,
            ILoggerFactory loggerFactory)
            : base(manager, contextInitializer, loggerFactory)
        {
        }
    }
}
