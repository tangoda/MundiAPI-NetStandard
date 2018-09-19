/*
 * MundiAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.Standard;
using MundiAPI.Standard.Utilities;


namespace MundiAPI.Standard.Models
{
    public class CreateCardOptionsRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool verifyCard;

        /// <summary>
        /// Indicates if the card should be verified before creation. If true, executes an authorization before saving the card.
        /// </summary>
        [JsonProperty("verify_card")]
        public bool VerifyCard 
        { 
            get 
            {
                return this.verifyCard; 
            } 
            set 
            {
                this.verifyCard = value;
                onPropertyChanged("VerifyCard");
            }
        }
    }
} 