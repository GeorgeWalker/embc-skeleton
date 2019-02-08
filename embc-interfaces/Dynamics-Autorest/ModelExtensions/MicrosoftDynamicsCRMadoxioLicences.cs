
namespace Gov.Jag.Embc.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq; using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class MicrosoftDynamicsCRMadoxioLicences
    {
        
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_account_adoxio_legalentity_Account@odata.bind")]
        public string AdoxioAccountAdoxioLegalentityAccountODataBind { get; set; }



        //enable accessing properties using string names
        [NotMapped] public object this[string propertyName]
        {
            get {
                if (propertyName.IndexOf(".") > -1)
                {
                    string[] tokens = propertyName.Split(".");
                    string firstToken = tokens[0];
                    string secondToken = tokens[1];
                    var property = this.GetType().GetProperty(firstToken).GetValue(this, null);
                    if (property == null)
                    {
                        return null;
                    }
                    else
                    {
                        return property.GetType().GetProperty(secondToken).GetValue(property, null);
                    }
                    
                }
                else
                {
                    return this.GetType().GetProperty(propertyName).GetValue(this, null);
                }
            }
                
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }
    }
}
