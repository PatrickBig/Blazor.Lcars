using Blazor.Lcars.Base;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Lcars
{
    public partial class Frame : LcarsBase
    {
        [Parameter]
        public FrameHorizontal Horizontal { get; set; }

        [Parameter]
        public FrameSide Side { get; set; }
    }
}
