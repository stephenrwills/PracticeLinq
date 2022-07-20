using System;
using System.Collections.Generic;
using System.Linq;

List<string> videoGames = new List<string>() { 

    "Donkey Kong",
    "Banjo Kazooie",
    "Jade Empire",
    "Fallout",
    "Portal",
    "Bloodborne"
};

videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));



