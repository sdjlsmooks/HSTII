using NLog;
using NTST.ScriptLinkService.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace ScriptLinkStub
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TII: System.Web.Services.WebService
    {

        [WebMethod]
        public string GetVersion()
        {
            return "1.0";
        }

        [WebMethod]
        public OptionObject2015 RunScript(OptionObject2015 inputObject, String scriptParameter)
        {/*
            var config = new NLog.Config.LoggingConfiguration();

            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "c:\\temp\\log_06_04_2020.txt" };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

            // Rules for mapping loggers to targets            
            config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            // Apply config           
            NLog.LogManager.Configuration = config;
            */
            Logger log = LogManager.GetCurrentClassLogger();
            
            log.Debug("SDJL - BEGIN RunScript");

            // Actually perform the action
            OptionObject2015 returnObject = CopyObject(inputObject);

            DateTime dateOfService;
            String recipientOfBloodTransfusion = ""; // ti_1
            String longTermHemoDialysis = ""; //ti_2
            String recipientClottingFactor = ""; // ti_3
            String stuckByNeedle = ""; // ti_4
            String birthMotherHepatitis = ""; // ti_5

            // ti_6
            String yellowDiscoloration = "";
            String swellingAbdomen = "";
            String abnormalLiver = "";
            String nausea = "";
            String abnormalBloodClotting = "";
            String lossAppetiteWeight = "";
            String dilationArteries = "";


            String sexPartnersHepBC = ""; // ti_7
            String tattooPiercing = ""; // ti_8


            // ti_9a
            String closeContactActiveTB = "";
            String hadPositiveTBTest = "";
            String treatedForTB = "";
            String hadAbnormalChestXRay = "";

            // ti_9b
            String diagnosedWithHIV = "";
            String blackLung = "";
            String kidneyFailure = "";
            String diabetes = "";
            String bleedingClottingDisorders = "";
            String silicosis = "";
            String specificMalignancies = "";
            String anyOtherImmuneDisorder = "";

            // ti_10
            String riskyPlaces = "";

            // ti_11
            String employedHealthCareVolunteerHighRisk = "";

            // ti_12
            String correctionFacility = "";
            String homelessShelter = "";
            String nursingHome = "";
            String residentialTreatmentFacility = "";
            String mentalInstitution = "";
            String transitionalLiving = "";

            // ti_13[0..6] - Field Number: 86.36 - Mark all of the following that currently apply
            String continuousCough = "";
            String prolongedLossAppetite = "";
            String coughedUpBlood = "";
            String unexplainedWeightLoss = "";
            String swollenLymphNodes = "";
            String recurrentFevers = "";

            //ti_14 - Field Number 86.48 - Have you had multiple sexual partners
            String multipleSexPartners = "";

            // ti_15 - Field Number: 86.49 - Have you ever had anal sex?
            String analSex = "";

            // ti_16 - FieldNumber: 86.37 -  How often have you used protection
            Int64 usedProtection = 0;

            // ti_17 - FieldNumber: 86.50 - Have you used a needle to inject any substance.
            String usedNeedle = "";

            // ti_18 - FieldNumber: 86.51 - .. your sexual partner ever injected any substance with a needle.
            String sexPartnerUsedNeedle = "";

            // ti_19 - FieldNumber: 86.38 - Hav you or any of your sexual partners ever had...
            String gonorrhea = "";
            String hpv = "";
            String cervicalCancer = "";
            String syphilis = "";
            String genitalHerpes = "";
            String chlamydia = "";
            String hepatitis = "";


            // Return values;
            String referForHepTest = "";


            //Add your script call(s) here
            switch (scriptParameter)
            {
                case "HS_TIInfectiousDisease Calculate":
                    foreach (FormObject form in inputObject.Forms)
                    {
                        foreach (FieldObject field in form.CurrentRow.Fields)
                        {
                            if (field.FieldNumber.Equals("86.29"))
                            {
                                String dateOfServiceString = field.FieldValue;
                                try
                                {
                                    dateOfService = DateTime.Parse(dateOfServiceString);
                                }
                                catch (FormatException e)
                                {
                                    returnObject.Forms.ElementAt(0).CurrentRow.RowAction = "EDIT";
                                    returnObject.ErrorCode = 3;
                                    returnObject.ErrorMesg = "Invalid Date Format";
                                    return returnObject;
                                }
                            }
                            // ti_1
                            if (field.FieldNumber.Equals("86.42"))
                            {
                                recipientOfBloodTransfusion = field.FieldValue;
                            }
                            // ti_2
                            if (field.FieldNumber.Equals("86.42"))
                            {
                                longTermHemoDialysis = field.FieldValue;
                            }
                            // ti_3
                            if (field.FieldNumber.Equals("86.52"))
                            {
                                recipientClottingFactor = field.FieldValue;
                            }
                            // ti_4
                            if (field.FieldNumber.Equals("86.43"))
                            {
                                stuckByNeedle = field.FieldValue;
                            }
                            // ti_5
                            if (field.FieldNumber.Equals("86.44"))
                            {
                                birthMotherHepatitis = field.FieldValue;
                            }

                            // ti_6
                            if (field.FieldNumber.Equals("86.31"))
                            {
                                Console.WriteLine("SDJL - ti_6 - RAW: '" + field.FieldValue + "'");
                                String markAllOfTheFollowing = field.FieldValue;
                                String[] markAllSelected = markAllOfTheFollowing.Split('&');

                                foreach (String selection in markAllSelected)
                                {
                                    switch (selection)
                                    {
                                        case "1":
                                            yellowDiscoloration = "Y";
                                            break;

                                        case "2":
                                            swellingAbdomen = "Y";
                                            break;

                                        case "3":
                                            abnormalLiver = "Y";
                                            break;

                                        case "4":
                                            nausea = "Y";
                                            break;

                                        case "5":
                                            abnormalBloodClotting = "Y";
                                            break;

                                        case "6":
                                            lossAppetiteWeight = "Y";
                                            break;

                                        case "7":
                                            dilationArteries = "Y";
                                            break;
                                    }
                                }
                            }

                            // ti_7
                            if (field.FieldNumber.Equals("86.32"))
                            {
                                sexPartnersHepBC = field.FieldValue;
                            }

                            // ti_8
                            if (field.FieldNumber.Equals("86.45"))
                            {
                                tattooPiercing = field.FieldValue;
                            }

                            // ti_9
                            if (field.FieldNumber.Equals("86.33"))
                            {
                                Console.WriteLine("SDJL - 9A RAW: '" + field.FieldValue + "'");
                                String selectedValues = field.FieldValue;
                                String[] selection = selectedValues.Split('&');
                                foreach (String value in selection)
                                {
                                    switch (value)
                                    {
                                        case "1":
                                            closeContactActiveTB = "Y";
                                            break;

                                        case "2":
                                            hadPositiveTBTest = "Y";
                                            break;

                                        case "3":
                                            treatedForTB = "Y";
                                            break;

                                        case "4":
                                            hadAbnormalChestXRay = "Y";
                                            break;
                                    }
                                }
                            }

                            // ti_9b
                            if (field.FieldNumber.Equals("86.34"))
                            {
                                String selection = field.FieldValue;
                                String[] allSelected = selection.Split('&');

                                foreach (String value in allSelected)
                                {
                                    switch (value)
                                    {
                                        case "1":
                                            diagnosedWithHIV = "Y";
                                            break;

                                        case "2":
                                            blackLung = "Y";
                                            break;

                                        case "3":
                                            kidneyFailure = "Y";
                                            break;

                                        case "4":
                                            diabetes = "Y";
                                            break;

                                        case "5":
                                            bleedingClottingDisorders = "Y";
                                            break;

                                        case "6":
                                            silicosis = "Y";
                                            break;

                                        case "7":
                                            specificMalignancies = "Y";
                                            break;

                                        case "8":
                                            anyOtherImmuneDisorder = "Y";
                                            break;

                                    }
                                }
                            }

                            // ti_10
                            if (field.FieldNumber.Equals("86.46"))
                            {
                                riskyPlaces = field.FieldValue;
                            }

                            // ti_11
                            if (field.FieldNumber.Equals("86.47"))
                            {
                                employedHealthCareVolunteerHighRisk = field.FieldValue;
                            }

                            // ti_12
                            if (field.FieldNumber.Equals("86.35"))
                            {
                                String allSelected = field.FieldValue;
                                String[] selected = allSelected.Split('&');
                                foreach (String selection in selected)
                                {
                                    switch (selection)
                                    {
                                        case "1":
                                            correctionFacility = "Y";
                                            break;

                                        case "2":
                                            homelessShelter = "Y";
                                            break;

                                        case "3":
                                            nursingHome = "y";
                                            break;

                                        case "4":
                                            residentialTreatmentFacility = "Y";
                                            break;

                                        case "5":
                                            mentalInstitution = "Y";
                                            break;

                                        case "6":
                                            transitionalLiving = "Y";
                                            break;
                                    }
                                }
                            }

                            //ti_13
                            if (field.FieldNumber.Equals("86.36"))
                            {

                                String allSelected = field.FieldValue;
                                String[] selected = allSelected.Split('&');
                                foreach (String selection in selected)
                                {
                                    switch (selection)
                                    {
                                        case "1":
                                            continuousCough = "Y";
                                            break;

                                        case "2":
                                            prolongedLossAppetite = "Y";
                                            break;

                                        case "3":
                                            coughedUpBlood = "Y";
                                            break;

                                        case "4":
                                            unexplainedWeightLoss = "Y";
                                            break;

                                        case "5":
                                            swollenLymphNodes = "Y";
                                            break;

                                        case "6":
                                            recurrentFevers = "Y";
                                            break;
                                    }
                                }
                            }

                            // ti_14
                            if (field.FieldNumber.Equals("86.48"))
                            {

                            }

                            // ti_15
                            if (field.FieldNumber.Equals("86.49"))
                            {
                                multipleSexPartners = field.FieldValue;
                            }

                            // ti_16
                            if (field.FieldNumber.Equals("86.37"))
                            {
                                usedProtection = Int64.Parse(field.FieldValue);
                            }

                            // ti_17
                            if (field.FieldNumber.Equals("86.5"))
                            {
                                usedNeedle = field.FieldValue;
                            }

                            // ti_18
                            if (field.FieldNumber.Equals("86.51"))
                            {
                                sexPartnerUsedNeedle = field.FieldValue;
                            }

                            // ti_19
                            if (field.FieldNumber.Equals("86.38"))
                            {
                                String allSelected = field.FieldValue;
                                String[] selected = allSelected.Split('&');
                                foreach (String selection in selected)
                                {
                                    switch (selection)
                                    {
                                        case "1":
                                            gonorrhea = "Y";
                                            break;

                                        case "2":
                                            hpv = "Y";
                                            break;

                                        case "3":
                                            cervicalCancer = "Y";
                                            break;

                                        case "4":
                                            syphilis = "Y";
                                            break;

                                        case "5":
                                            genitalHerpes = "Y";
                                            break;

                                        case "6":
                                            chlamydia = "Y";
                                            break;

                                        case "7":
                                            hepatitis = "Y";
                                            break;
                                    }
                                }
                            }
                        }
                    }


                    /*

      
                    */

                    // PERFORM SCORE CALCULATIONS FOR CLIENT RECOMMENDATIONS
                    // There are 6 seperate scores that are calculated. to determine which check box to select
                    // 1.)  symptomsExperienced
                    // 2.)  tattooPiercing
                    // 3.)  risksExperienced
                    // 4.)  selfNeedle
                    // 5.)  moreSymptoms
                    // 6.)  multipleSexPartners

                    // 1.)  from symptomsExperiences
                    Double score1 = 0;

                    // score = ti_1 + ti_2 + ti_3 + ti_4 + ti_5 + ti_7 + sum(ti_6)
                    score1 += recipientOfBloodTransfusion.Equals("Y") ? 1 : 0; // ti_1
                    score1 += longTermHemoDialysis.Equals("Y") ? 1 : 0; // ti_2
                    score1 += recipientClottingFactor.Equals("Y") ? 1 : 0; // ti_3
                    score1 += stuckByNeedle.Equals("Y") ? 1 : 0; // ti_4
                    score1 += birthMotherHepatitis.Equals("Y") ? 1 : 0; // ti_5
                    score1 += sexPartnersHepBC.Equals("Y") ? 1 : 0;  // ti_7

                    // Score1 += (sum of ti_6 elements)
                    score1 += yellowDiscoloration.Equals("Y") ? 1 : 0;
                    score1 += swellingAbdomen.Equals("Y") ? 1 : 0;
                    score1 += abnormalLiver.Equals("Y") ? 1 : 0;
                    score1 += nausea.Equals("Y") ? 1 : 0;
                    score1 += abnormalBloodClotting.Equals("Y") ? 1 : 0;
                    score1 += lossAppetiteWeight.Equals("Y") ? 1 : 0;
                    score1 += dilationArteries.Equals("Y") ? 1 : 0;

                    if (score1 > 0)
                    {
                        referForHepTest = "Y";
                    }

                    // score 2 - ti_8
                    Double score2 = 0.0;
                    String notifyClientsOfRisks = "";

                    score2 += tattooPiercing.Equals("Y") ? 1 : 0;
                    if (score2 > 0)
                    {
                        notifyClientsOfRisks = "Y";
                    }


                    // score 3 = sum(ti_9 elements) + ti_12 +
                    // ti_10 + ti_11 + sum(ti_9) + sum(ti_9b) + sum(ti_12)
                    Double score3 = 0.0;
                    String recommendTBTest = "";

                    score3 += riskyPlaces.Equals("Y") ? 1 : 0; // ti_10
                    score3 += employedHealthCareVolunteerHighRisk.Equals("Y") ? 1 : 0; //ti_11

                    // sum(ti_9)
                    score3 += closeContactActiveTB.Equals("Y") ? 1 : 0;
                    score3 += hadPositiveTBTest.Equals("Y") ? 1 : 0;
                    score3 += treatedForTB.Equals("Y") ? 1 : 0;
                    score3 += hadAbnormalChestXRay.Equals("Y") ? 1 : 0;

                    // sum(ti_9b)
                    score3 += diagnosedWithHIV.Equals("Y") ? 1 : 0;
                    score3 += blackLung.Equals("Y") ? 1 : 0;
                    score3 += kidneyFailure.Equals("Y") ? 1 : 0;
                    score3 += diabetes.Equals("Y") ? 1 : 0;
                    score3 += bleedingClottingDisorders.Equals("Y") ? 1 : 0;
                    score3 += silicosis.Equals("Y") ? 1 : 0;
                    score3 += specificMalignancies.Equals("Y") ? 1 : 0;
                    score3 += anyOtherImmuneDisorder.Equals("Y") ? 1 : 0;

                    // sum(ti_12)
                    score3 += correctionFacility.Equals("Y") ? 1 : 0;
                    score3 += homelessShelter.Equals("Y") ? 1 : 0;
                    score3 += nursingHome.Equals("Y") ? 1 : 0;
                    score3 += residentialTreatmentFacility.Equals("Y") ? 1 : 0;
                    score3 += mentalInstitution.Equals("Y") ? 1 : 0;
                    score3 += transitionalLiving.Equals("Y") ? 1 : 0;

                    if (score3 > 0)
                    {
                        recommendTBTest = "Y";
                    }

                    // score 4 - ti_17 - Have you used a needle
                    Double score4 = 0.0;
                    String highRiskOfTB = "";
                    String encourageHIVHEPTest = "";

                    score4 = 0;
                    score4 += usedNeedle.Equals("Y") ? 1 : 0;
                    if (score4 > 0)
                    {
                        encourageHIVHEPTest = "Y";
                    }


                    // score 5 - sum of ti_13 elements (Mark all of the following...)
                    Double score5 = 0.0;

                    score5 += continuousCough.Equals("Y") ? 1 : 0;
                    score5 += prolongedLossAppetite.Equals("Y") ? 1 : 0;
                    score5 += coughedUpBlood.Equals("Y") ? 1 : 0;
                    score5 += unexplainedWeightLoss.Equals("Y") ? 1 : 0;
                    score5 += swollenLymphNodes.Equals("Y") ? 1 : 0;
                    score5 += recurrentFevers.Equals("Y") ? 1 : 0;
                    if (score5 > 0)
                    {
                        highRiskOfTB = "Y";
                    }
                    // score 6 - ti_14 + ti_15 + ti_16 + ti_17 + ti_18 + sum(ti_19[i]*5)
                    Double score6 = 0;

                    score6 += multipleSexPartners.Equals("Y") ? 1 : 0; // ti_14
                    score6 += analSex.Equals("Y") ? 1 : 0; // ti_15
                    score6 += (usedProtection < 3) ? 1 : 0; // ti_16
                    score6 += usedNeedle.Equals("Y") ? 1 : 0; // ti_17
                    score6 += sexPartnerUsedNeedle.Equals("Y") ? 1 : 0; // ti_18

                    // sum(ti_19)
                    score6 += gonorrhea.Equals("Y") ? 5 : 0;
                    score6 += hpv.Equals("Y") ? 5 : 0;
                    score6 += cervicalCancer.Equals("Y") ? 5 : 0;
                    score6 += syphilis.Equals("Y") ? 5 : 0;
                    score6 += genitalHerpes.Equals("Y") ? 5 : 0;
                    score6 += chlamydia.Equals("Y") ? 5 : 0;
                    score6 += hepatitis.Equals("Y") ? 5 : 0;

                    String highRiskOfHIV = "";
                    String mediumRiskOfHIV = "";
                    String lowRiskOfHIV = "";

                    if (score6 > 44)
                    {
                        highRiskOfHIV = "Y";
                    }
                    else if (score6 > 24)
                    {
                        mediumRiskOfHIV = "Y";
                    }
                    else
                    {
                        lowRiskOfHIV = "Y";
                    }

                    Double total = score1 + score2 + score3 + score4 + score5 + score6;

                    // Construct the string Avatar expects to set the check boxes and 
                    // radio buttons correctly.  NOTE - ORDER IS IMPORTANT HERE!

                    String stdRiskFactors = "";
                    if (referForHepTest.Equals("Y"))
                    {
                        stdRiskFactors = "1";
                    }
                    if (notifyClientsOfRisks.Equals("Y"))
                    {
                        if (stdRiskFactors.Length > 0)
                        {
                            stdRiskFactors += "&";
                        }
                        stdRiskFactors += "2";
                    }
                    if (recommendTBTest.Equals("Y"))
                    {
                        if (stdRiskFactors.Length > 0)
                        {
                            stdRiskFactors += "&";
                        }
                        stdRiskFactors += "3";
                    }
                    if (usedNeedle.Equals("Y"))
                    {
                        if (stdRiskFactors.Length > 0)
                        {
                            stdRiskFactors += "&";
                        }
                        stdRiskFactors += "4";
                    }
                    if (highRiskOfTB.Equals("Y"))
                    {
                        if (stdRiskFactors.Length > 0)
                        {
                            stdRiskFactors += "&";
                        }
                        stdRiskFactors += "5";
                    }

                    String hivRiskLevel = "1"; // default
                    // Set Radio buttons
                    if (highRiskOfHIV.Equals("Y"))
                    {
                        hivRiskLevel = "1";
                    }
                    else if (mediumRiskOfHIV.Equals("Y"))
                    {
                        hivRiskLevel = "2";
                    }
                    else if (lowRiskOfHIV.Equals("Y"))
                    {
                        hivRiskLevel = "3";
                    }

                    // Set the values in the return object
                    // loop through fields until we find the check boxes and radio buttons.
                    foreach (FieldObject field in returnObject.Forms.ElementAt(0).CurrentRow.Fields)
                    {
                        if (field.FieldNumber.Equals("283.36"))
                        {
                            field.FieldValue = stdRiskFactors;
                        }
                        if (field.FieldNumber.Equals("283.37"))
                        {
                            field.FieldValue = hivRiskLevel;
                        }
                    }
                    returnObject.Forms.ElementAt(0).CurrentRow.RowAction = "EDIT";
                    returnObject.ErrorCode = 0;
                    returnObject.ErrorMesg = "";
                    // TIIInfectiousDiseaseCalculateScriptLinkService.ErrorTest(inputObject);
                    break;
            }
            log.Debug("SDJL - END RunScript");
            return returnObject;
        }

        private static OptionObject2015 CopyObject(OptionObject2015 inputObject)
        {
            OptionObject2015 returnObject = new OptionObject2015();
            returnObject.EntityID = inputObject.EntityID;
            returnObject.EpisodeNumber = inputObject.EpisodeNumber;
            returnObject.Facility = inputObject.Facility;
            returnObject.Forms = inputObject.Forms;
            returnObject.NamespaceName = inputObject.NamespaceName;
            returnObject.OptionId = inputObject.OptionId;
            returnObject.OptionStaffId = inputObject.OptionStaffId;
            returnObject.OptionUserId = inputObject.OptionUserId;
            returnObject.ParentNamespace = inputObject.ParentNamespace;
            returnObject.ServerName = inputObject.ServerName;
            returnObject.SessionToken = inputObject.SessionToken;
            returnObject.SystemCode = inputObject.SystemCode;
            return returnObject;
        }

        private static OptionObject2015 ErrorTest(OptionObject2015 inputObject)
        {
            OptionObject2015 returnObject = new OptionObject2015();
            returnObject.ErrorCode = 3;
            returnObject.ErrorMesg = "Test Message: 1/30/2020";
            return returnObject;
        }
    }
}
