using System;
using System.Collections.Generic;
using System.Text;

namespace InterpolApp.Navigation
{
    public class NavigationContext
    {
        public Uri Uri { get; private set; }
        public NavigationParameters Parameters { get; private set; }

        public NavigationContext(Uri uri)
        {
            this.Uri = uri;
        }

        public NavigationContext(Uri uri, NavigationParameters parameters) : this(uri)
        {
            this.Parameters = parameters;
        }
    }
}
