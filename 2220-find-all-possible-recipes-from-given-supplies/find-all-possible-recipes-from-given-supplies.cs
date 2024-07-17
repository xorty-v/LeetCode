public class Solution 
{
    public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies) {
        var graph = new Dictionary<string, List<string>>();
        var inDegree = new Dictionary<string, int>();

        for (int i = 0; i < ingredients.Count; i++)
        {
            for (int j = 0; j < ingredients[i].Count; j++)
            {
                if (!graph.ContainsKey(ingredients[i][j]))
                {
                    graph[ingredients[i][j]] = new List<string>();
                }

                graph[ingredients[i][j]].Add(recipes[i]);

                if (!inDegree.ContainsKey(recipes[i]))
                {
                    inDegree[recipes[i]] = 1;
                }
                else
                {
                    inDegree[recipes[i]]++;
                }
            }
        }

        var queue = new Queue<string>(supplies);
        var result = new List<string>();

        while (queue.Count > 0)
        {
            var supply = queue.Dequeue();

            if (!graph.ContainsKey(supply))
            {
                continue;
            }
            
            foreach (var recipe in graph[supply])
            {
                inDegree[recipe]--;

                if (inDegree[recipe] == 0)
                {
                    result.Add(recipe);
                    queue.Enqueue(recipe);
                }
            }
        }

        return result;
    }
}