/*
 * MundiAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
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
    public class UpdateRecipientBankAccountRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.CreateBankAccountRequest bankAccount;

        /// <summary>
        /// Bank account
        /// </summary>
        [JsonProperty("bank_account")]
        public Models.CreateBankAccountRequest BankAccount 
        { 
            get 
            {
                return this.bankAccount; 
            } 
            set 
            {
                this.bankAccount = value;
                onPropertyChanged("BankAccount");
            }
        }
    }
} 