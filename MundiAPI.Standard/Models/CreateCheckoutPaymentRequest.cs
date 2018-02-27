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
    public class CreateCheckoutPaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<string> acceptedPaymentMethods;
        private string successUrl;
        private bool skipCheckoutSuccessPage;
        private bool billingAddressEditable;
        private Models.CreateAddressRequest billingAddress;
        private string defaultPaymentMethod;
        private string gatewayAffiliationId;
        private Models.CreateCheckoutCardPaymentRequest creditCard;
        private Models.CreateCheckoutBoletoPaymentRequest boleto;
        private bool? customerEditable;
        private int? expiresIn;

        /// <summary>
        /// Accepted Payment Methods
        /// </summary>
        [JsonProperty("accepted_payment_methods")]
        public List<string> AcceptedPaymentMethods 
        { 
            get 
            {
                return this.acceptedPaymentMethods; 
            } 
            set 
            {
                this.acceptedPaymentMethods = value;
                onPropertyChanged("AcceptedPaymentMethods");
            }
        }

        /// <summary>
        /// Success url
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl 
        { 
            get 
            {
                return this.successUrl; 
            } 
            set 
            {
                this.successUrl = value;
                onPropertyChanged("SuccessUrl");
            }
        }

        /// <summary>
        /// Pular tela de sucesso pós-pagamento?
        /// </summary>
        [JsonProperty("skip_checkout_success_page")]
        public bool SkipCheckoutSuccessPage 
        { 
            get 
            {
                return this.skipCheckoutSuccessPage; 
            } 
            set 
            {
                this.skipCheckoutSuccessPage = value;
                onPropertyChanged("SkipCheckoutSuccessPage");
            }
        }

        /// <summary>
        /// Torna o objeto billing address editável
        /// </summary>
        [JsonProperty("billing_address_editable")]
        public bool BillingAddressEditable 
        { 
            get 
            {
                return this.billingAddressEditable; 
            } 
            set 
            {
                this.billingAddressEditable = value;
                onPropertyChanged("BillingAddressEditable");
            }
        }

        /// <summary>
        /// Endereço de cobrança
        /// </summary>
        [JsonProperty("billing_address")]
        public Models.CreateAddressRequest BillingAddress 
        { 
            get 
            {
                return this.billingAddress; 
            } 
            set 
            {
                this.billingAddress = value;
                onPropertyChanged("BillingAddress");
            }
        }

        /// <summary>
        /// Default payment method
        /// </summary>
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod 
        { 
            get 
            {
                return this.defaultPaymentMethod; 
            } 
            set 
            {
                this.defaultPaymentMethod = value;
                onPropertyChanged("DefaultPaymentMethod");
            }
        }

        /// <summary>
        /// Gateway Affiliation Id
        /// </summary>
        [JsonProperty("gateway_affiliation_id")]
        public string GatewayAffiliationId 
        { 
            get 
            {
                return this.gatewayAffiliationId; 
            } 
            set 
            {
                this.gatewayAffiliationId = value;
                onPropertyChanged("GatewayAffiliationId");
            }
        }

        /// <summary>
        /// Card payment request
        /// </summary>
        [JsonProperty("credit_card")]
        public Models.CreateCheckoutCardPaymentRequest CreditCard 
        { 
            get 
            {
                return this.creditCard; 
            } 
            set 
            {
                this.creditCard = value;
                onPropertyChanged("CreditCard");
            }
        }

        /// <summary>
        /// Boleto payment request
        /// </summary>
        [JsonProperty("boleto")]
        public Models.CreateCheckoutBoletoPaymentRequest Boleto 
        { 
            get 
            {
                return this.boleto; 
            } 
            set 
            {
                this.boleto = value;
                onPropertyChanged("Boleto");
            }
        }

        /// <summary>
        /// Torna o objeto editável
        /// </summary>
        [JsonProperty("customer_editable")]
        public bool? CustomerEditable 
        { 
            get 
            {
                return this.customerEditable; 
            } 
            set 
            {
                this.customerEditable = value;
                onPropertyChanged("CustomerEditable");
            }
        }

        /// <summary>
        /// Tempo em minutos para a expiração
        /// </summary>
        [JsonProperty("expires_in")]
        public int? ExpiresIn 
        { 
            get 
            {
                return this.expiresIn; 
            } 
            set 
            {
                this.expiresIn = value;
                onPropertyChanged("ExpiresIn");
            }
        }
    }
} 