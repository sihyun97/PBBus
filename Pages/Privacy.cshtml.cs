using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace pbbustest.Pages
{

    public class PrivacyModel : PageModel
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "bAwZm2aBzoDgOIhl0jmD6yHffLF0YYT0OwxwWz3i",
            BasePath = "https://pbbus-1fb21.firebaseio.com/"
        };
        IFirebaseClient clinet;
        
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
            clinet = new FireSharp.FirebaseClient(config);
        }

        public void OnGet()
        {
        }
        private void button1(object sender, EventArgs e)
        {
            var data = new Data
            {
                ID = textBox.text
            };
            SetResponse response = await Client.SetAsync("");
        }
    }
}
