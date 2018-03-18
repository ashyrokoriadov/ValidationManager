using System;
using System.Collections.Generic;
using System.Resources;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ValidationManager
{
    [ObsoleteAttribute("This class is obsolete. Use Validator class instead.", false)]
    public class ValidationMessageManager
    {
        public string ResourcesFileName { get; private set; }

        Assembly Assembly { get; set; }

        ResourceManager ResourceManager { get; set; }

        public ValidationMessageManager(string ResourcesFileName, Assembly Assembly)
        {
            this.ResourcesFileName = ResourcesFileName;
            ResourceManager = new ResourceManager(ResourcesFileName, Assembly);
        }

        public string GetValidationMessageFromCodeString(string ValidationMessageCodeString)
        {
            StringBuilder ValidatiomMessageResponse = new StringBuilder();
            string[] errorMessages = ValidationMessageCodeString.Split(' ');

            foreach (string errorMessage in errorMessages)
            {
                ValidatiomMessageResponse.AppendFormat("{0}&nbsp;", ResourceManager.GetString("Code" + errorMessage));
            }

            return ValidatiomMessageResponse.ToString();
        }
    }
}
