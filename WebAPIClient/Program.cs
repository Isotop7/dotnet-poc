using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;

namespace WebAPIClient
{
    class Program
    {
        private static readonly HttpClient cli = new HttpClient();

        static async Task Main(string[] args)
        {
            var username = "Isotop7";
            var repositories = await ProcessRepositories(username);
            Console.WriteLine("Found the following repos for user '" + username + "':");
            foreach (var repo in repositories)
            {
                Console.WriteLine("> " + repo.Name);
                Console.WriteLine("Description: " + repo.Description);
                Console.WriteLine("Home URL: " + repo.GitHubHomeUrl);
                Console.WriteLine("Homepage: " + repo.Homepage);
                Console.WriteLine("Watchers: " + repo.Watchers);
                Console.WriteLine("Last push: " + repo.LastPush);
            }
        }

        private static async Task<List<Repository>> ProcessRepositories(string username)
        {
            cli.DefaultRequestHeaders.Accept.Clear();
            cli.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json")
            );
            cli.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var repoURL = "https://api.github.com/users/" + username + "/repos";
            var streamTask = cli.GetStreamAsync(repoURL);
            return await JsonSerializer.DeserializeAsync<List<Repository>>(await streamTask);
        }
    }
}
