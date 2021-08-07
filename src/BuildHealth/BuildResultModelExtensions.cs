using BuildHealth.Data.Models;
using System;

namespace BuildHealth
{
    public static class BuildResultModelExtensions
    {
        public static string ResultColor(this BuildResultModel resultModel)
        {
            return resultModel.Result ? "green" : "red";
        }

        public static TimeSpan Duration(this BuildResultModel resultModel)
        {
            return resultModel.FinishTime - resultModel.StartTime;
        }

        public static TimeSpan TimeSinceCompletion(this BuildResultModel resultModel)
        {
            return DateTime.Now - resultModel.FinishTime;
        }
    }
}
