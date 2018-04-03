using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Exchange.WebServices.Data;
using System.Net;
using log4net;
using System.Security;

namespace CategoryManager
{
    public class ExchangeHelper
    {
        private static readonly LogHelper log = new LogHelper();

        /// <summary>
        /// Connect to Exchange using AutoDiscover for the given email address
        /// </summary>
        /// <param name="UseDefaultCredentials">if set to true, UserName and Password will be ignored and the session credentials will be used</param>
        /// <param name="UserName">UserName for the connection</param>
        /// <param name="Password">Password for the connection</param>
        /// <param name="Mailbox">If Impersonate is true, the Mailbox is neeed which should be impersonated</param>
        /// <param name="AllowRedirection">Should normaly set to true </param>
        /// <param name="Impersonate">If a mailbox should be impersonated, this need to be set to true</param>
        /// <param name="IgnoreCertificateErrors">At now not implemented. Will be Ignored.</param>
        /// <returns>Exchange Web Service binding</returns>
        public ExchangeService Service(bool UseDefaultCredentials, string UserName, SecureString Password, string Mailbox, bool AllowRedirection, bool Impersonate, bool IgnoreCertificateErrors)
        {
                log.WriteDebugLog("Connecting to exchange with following settings:");
                log.WriteDebugLog(string.Format("UseDefaultCredentials: {0}", UseDefaultCredentials.ToString()));
                if (UserName.Length > 0)
                {
                    log.WriteDebugLog(string.Format("UserName: {0}", UserName));
                }
                if (Password != null)
                {
                    log.WriteDebugLog("Passwort: set");
                }

                log.WriteDebugLog(string.Format("Mailbox: {0}", Mailbox));
                log.WriteDebugLog(string.Format("AllowRedirection: {0}", AllowRedirection.ToString()));
                log.WriteDebugLog(string.Format("Impersonate: {0}", Impersonate.ToString()));
                log.WriteDebugLog(string.Format("IgnoreCertificateErrors: {0}", IgnoreCertificateErrors.ToString()));
            if (IgnoreCertificateErrors)
            {
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            }

            var service = new ExchangeService();
            try
            {
                if (UseDefaultCredentials)
                {
                    service.UseDefaultCredentials = true;
                }
                else
                {
                    service.Credentials = new WebCredentials(UserName, SecureStringHelper.SecureStringToString(Password));
                }

                if (AllowRedirection)
                {
                    service.AutodiscoverUrl(Mailbox, url => true);
                }
                else
                {
                    service.AutodiscoverUrl(Mailbox);
                }

                if (Impersonate)
                {
                    service.ImpersonatedUserId = new ImpersonatedUserId(ConnectingIdType.SmtpAddress, Mailbox);
                }
                log.WriteDebugLog("Service successfully created.");
   
                return service;
            }
            catch(Exception ex)
            {
                log.WriteErrorLog("Error on creating service.");
                log.WriteErrorLog(string.Format("Exception: {0}", ex.Message));
                return null;
                
            }
        }

        /// <summary>
        /// Connect to Exchange using an URL for the given email address
        /// </summary>
        /// <param name="UseDefaultCredentials">if set to true, UserName and Password will be ignored</param>
        /// <param name="UseDefaultCredentials">if set to true, UserName and Password will be ignored and the session credentials will be used</param>
        /// <param name="UserName">UserName for the connection</param>
        /// <param name="Password">Password for the connection</param>
        /// <param name="Mailbox">If Impersonate is true, the Mailbox is neeed which should be impersonated</param>
        /// <param name="AllowRedirection">Should normaly set to true </param>
        /// <param name="Impersonate">If a mailbox should be impersonated, this need to be set to true</param>
        /// <param name="IgnoreCertificateErrors">At now not implemented. Will be Ignored.</param>
        /// <param name="Url">URL of the Exchange server. Will be normally used with IgnoreCertificateErrors</param>
        /// <returns></returns>
        public ExchangeService Service(bool UseDefaultCredentials, string UserName, SecureString Password, string Mailbox, string Url, bool Impersonate, bool IgnoreCertificateErrors)
        {
                log.WriteDebugLog("Connecting to exchange with following settings:");
                log.WriteDebugLog(string.Format("UseDefaultCredentials: {0}", UseDefaultCredentials.ToString()));
                if (UserName.Length > 0)
                {
                    log.WriteDebugLog(string.Format("UserName: {0}", UserName));
                }
                if (Password != null)
                {
                    log.WriteDebugLog("Passwort: set");
                }   
                log.WriteDebugLog(string.Format("Mailbox: {0}", Mailbox));
                log.WriteDebugLog(string.Format("Url: {0}", Url));
                log.WriteDebugLog(string.Format("Impersonate: {0}", Impersonate.ToString()));
                log.WriteDebugLog(string.Format("IgnoreCertificateErrors: {0}", IgnoreCertificateErrors.ToString()));

            if (IgnoreCertificateErrors)
            {
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            }

            var service = new ExchangeService();
            try
            {
                

                if (UseDefaultCredentials)
                {
                    service.UseDefaultCredentials = true;
                }
                else
                {
                    service.Credentials = new WebCredentials(UserName, SecureStringHelper.SecureStringToString(Password));
                }

                if (Url != "")
                {
                    service.Url = new Uri(Url);
                }

                if (Impersonate)
                {
                    service.ImpersonatedUserId = new ImpersonatedUserId(ConnectingIdType.SmtpAddress, Mailbox);
                }
                log.WriteDebugLog("Service successfully created.");

                return service;
            }
            catch(Exception ex)
            {
                log.WriteErrorLog("Error on creating service.");
                log.WriteErrorLog(string.Format("Exception: {0}", ex.Message));
                return null;
            }
        }
    }
}
