using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidBlazorWasm.Model
{

    public class USCurrentCovidData
    {
        public string fips { get; set; }
        public string country { get; set; }
        public object state { get; set; }
        public object county { get; set; }
        public string level { get; set; }
        public object lat { get; set; }
        public string locationId { get; set; }
        public object _long { get; set; }
        public int population { get; set; }
        public Metrics metrics { get; set; }
        public Risklevels riskLevels { get; set; }
        public int cdcTransmissionLevel { get; set; }
        public Actuals actuals { get; set; }
        public Annotations annotations { get; set; }
        public string lastUpdatedDate { get; set; }
        public object url { get; set; }
    }

    public class Metrics
    {
        public float testPositivityRatio { get; set; }
        public Testpositivityratiodetails testPositivityRatioDetails { get; set; }
        public float caseDensity { get; set; }
        public float contactTracerCapacityRatio { get; set; }
        public float infectionRate { get; set; }
        public float infectionRateCI90 { get; set; }
        public float icuCapacityRatio { get; set; }
        public float vaccinationsInitiatedRatio { get; set; }
        public float vaccinationsCompletedRatio { get; set; }
    }

    public class Testpositivityratiodetails
    {
        public string source { get; set; }
    }

    public class Risklevels
    {
        public int overall { get; set; }
        public int testPositivityRatio { get; set; }
        public int caseDensity { get; set; }
        public int contactTracerCapacityRatio { get; set; }
        public int infectionRate { get; set; }
        public int icuCapacityRatio { get; set; }
    }

    public class Actuals
    {
        public int cases { get; set; }
        public int deaths { get; set; }
        public int positiveTests { get; set; }
        public int negativeTests { get; set; }
        public int contactTracers { get; set; }
        public Hospitalbeds hospitalBeds { get; set; }
        public Icubeds icuBeds { get; set; }
        public int newCases { get; set; }
        public int newDeaths { get; set; }
        public int vaccinesDistributed { get; set; }
        public int vaccinationsInitiated { get; set; }
        public int vaccinationsCompleted { get; set; }
        public int vaccinesAdministered { get; set; }
        public object vaccinesAdministeredDemographics { get; set; }
        public object vaccinationsInitiatedDemographics { get; set; }
    }

    public class Hospitalbeds
    {
        public int capacity { get; set; }
        public int currentUsageTotal { get; set; }
        public int currentUsageCovid { get; set; }
    }

    public class Icubeds
    {
        public int capacity { get; set; }
        public int currentUsageTotal { get; set; }
        public int currentUsageCovid { get; set; }
    }

    public class Annotations
    {
        public Cases cases { get; set; }
        public Deaths deaths { get; set; }
        public object positiveTests { get; set; }
        public object negativeTests { get; set; }
        public object contactTracers { get; set; }
        public object hospitalBeds { get; set; }
        public object icuBeds { get; set; }
        public object newCases { get; set; }
        public Newdeaths newDeaths { get; set; }
        public Vaccinesdistributed vaccinesDistributed { get; set; }
        public Vaccinationsinitiated vaccinationsInitiated { get; set; }
        public Vaccinationscompleted vaccinationsCompleted { get; set; }
        public Vaccinesadministered vaccinesAdministered { get; set; }
        public object testPositivityRatio { get; set; }
        public Casedensity caseDensity { get; set; }
        public object contactTracerCapacityRatio { get; set; }
        public Infectionrate infectionRate { get; set; }
        public Infectionrateci90 infectionRateCI90 { get; set; }
        public object icuCapacityRatio { get; set; }
        public object vaccinationsInitiatedRatio { get; set; }
        public object vaccinationsCompletedRatio { get; set; }
    }

    public class Cases
    {
        public Source[] sources { get; set; }
        public object[] anomalies { get; set; }
    }

    public class Source
    {
        public string type { get; set; }
        public string url { get; set; }
        public string name { get; set; }
    }

    public class Deaths
    {
        public Source1[] sources { get; set; }
        public object[] anomalies { get; set; }
    }

    public class Source1
    {
        public string type { get; set; }
        public string url { get; set; }
        public string name { get; set; }
    }

    public class Newdeaths
    {
        public object[] sources { get; set; }
        public Anomaly[] anomalies { get; set; }
    }

    public class Anomaly
    {
        public string date { get; set; }
        public string type { get; set; }
        public float original_observation { get; set; }
    }

    public class Vaccinesdistributed
    {
        public Source2[] sources { get; set; }
        public object[] anomalies { get; set; }
    }

    public class Source2
    {
        public string type { get; set; }
        public string url { get; set; }
        public string name { get; set; }
    }

    public class Vaccinationsinitiated
    {
        public Source3[] sources { get; set; }
        public object[] anomalies { get; set; }
    }

    public class Source3
    {
        public string type { get; set; }
        public string url { get; set; }
        public string name { get; set; }
    }

    public class Vaccinationscompleted
    {
        public Source4[] sources { get; set; }
        public object[] anomalies { get; set; }
    }

    public class Source4
    {
        public string type { get; set; }
        public string url { get; set; }
        public string name { get; set; }
    }

    public class Vaccinesadministered
    {
        public Source5[] sources { get; set; }
        public object[] anomalies { get; set; }
    }

    public class Source5
    {
        public string type { get; set; }
        public string url { get; set; }
        public string name { get; set; }
    }

    public class Casedensity
    {
        public Source6[] sources { get; set; }
        public object[] anomalies { get; set; }
    }

    public class Source6
    {
        public string type { get; set; }
        public string url { get; set; }
        public string name { get; set; }
    }

    public class Infectionrate
    {
        public Source7[] sources { get; set; }
        public object[] anomalies { get; set; }
    }

    public class Source7
    {
        public string type { get; set; }
        public string url { get; set; }
        public string name { get; set; }
    }

    public class Infectionrateci90
    {
        public Source8[] sources { get; set; }
        public object[] anomalies { get; set; }
    }

    public class Source8
    {
        public string type { get; set; }
        public string url { get; set; }
        public string name { get; set; }
    }

}
