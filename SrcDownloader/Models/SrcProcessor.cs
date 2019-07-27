#region Title Header

// Name: Phillip Smith
// 
// Solution: SrcDownloader
// Project: SrcDownloader
// File Name: SrcProcessor.cs
// 
// Current Data:
// 2019-07-27 9:28 PM
// 
// Creation Date:
// 2019-07-27 6:38 PM

#endregion

using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl;
using SrcDownloader.Models.SRC_Models;
using SRCom_Leaderboard_Downloader.Models;

namespace SrcDownloader.Models
{
    internal class SrcProcessor
    {
        public async Task<SrcData> LoadSrcGameData(string leaderboard, string category, VariableApiModel[] variables)
        {
            // check game exists

            var query = variables.Aggregate(string.Empty,
                (current, variable) => current + $"{variable.Id}={variable.Value}&");


            var uri = Url.Combine(ApiHelper.ApiClient.BaseAddress.ToString(), "leaderboard", leaderboard, "category",
                category, "?embed=players", query);


            using (var response = await ApiHelper.ApiClient.GetAsync(uri))
            {
                // error handle 
                if (!response.IsSuccessStatusCode)
                {
                    return new SrcData();
                }

                // read data
                var srcData = await response.Content.ReadAsAsync<SrcData>();

                return srcData;
            }
        }
    }
}