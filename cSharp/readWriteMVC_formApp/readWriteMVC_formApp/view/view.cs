using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readWriteMVC_formApp.view
{
    interface ViewI
    {
        string fNameText { get; set; }
        string lNameText { get; set; }
        string idText { get; set; }
        string ageText { get; set; }
        string heightText { get; set; }
        string weightText { get; set; }
    }
}
