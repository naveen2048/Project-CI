﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup ( typeof ( Web_App_CI.Startup ) )]

namespace Web_App_CI
{
  public partial class Startup
  {
    public void Configuration( IAppBuilder app )
    {
      ConfigureAuth ( app );
    }
  }
}
