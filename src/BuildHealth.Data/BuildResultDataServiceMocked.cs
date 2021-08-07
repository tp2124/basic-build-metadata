using BuildHealth.Data.Interfaces;
using BuildHealth.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildHealth.Data
{
    public class BuildResultDataServiceMocked : IBuildResultDataService
    {
        private List<BuildResultModel> _mockedDataSet;
        public BuildResultDataServiceMocked()
        {
            _mockedDataSet = new List<BuildResultModel>();
            var now = DateTime.Now;
            _mockedDataSet.Add(new BuildResultModel() { Id = 1, ChangelistCutoff = 11, StartTime = now - TimeSpan.FromMinutes(4.23), FinishTime = now - TimeSpan.FromMinutes(0.3) });
            _mockedDataSet.Add(new BuildResultModel() { Id = 2, ChangelistCutoff = 12, StartTime = now - TimeSpan.FromMinutes(3.73), FinishTime = now - TimeSpan.FromMinutes(0.2) });
            _mockedDataSet.Add(new BuildResultModel() { Id = 3, ChangelistCutoff = 24, StartTime = now - TimeSpan.FromMinutes(2.15), FinishTime = now - TimeSpan.FromMinutes(0.069) });
        }

        public async Task<List<BuildResultModel>> GetBuilds()
        {
            return _mockedDataSet;
        }

        public Task SaveBuildResults(List<BuildResultModel> newData)
        {
            return Task.Run(() => {
                _mockedDataSet = newData;
                return Task.CompletedTask;
            });
        }
    }
}
