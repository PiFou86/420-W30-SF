// Thread t1 = new Thread(() => {
//     Enumerable.Range(0, 10).ToList().ForEach(x => {
//         Singleton.Instance.Ecrire("t1");
//         Thread.Sleep(Random.Shared.Next(1, 50));
//     });
// });
// Thread t2 = new Thread(() => {
//     Enumerable.Range(0, 10).ToList().ForEach(x => {
//         Singleton.Instance.Ecrire("t2");
//         Thread.Sleep(Random.Shared.Next(1, 50));
//     });
// });

// Console.Out.WriteLine("Sans lock");
// t1.Start();
// t2.Start();

// t1.Join();
// t2.Join();

object _lock = new object();
// t1 = new Thread(() => {
//     Thread.Sleep(100);
//     lock(_lock) {
//         Enumerable.Range(0, 10).ToList().ForEach(x => {
//             Singleton.Instance.Ecrire("t1");
//             Thread.Sleep(Random.Shared.Next(1, 50));
//         });
//     }
// });
// t2 = new Thread(() => {
//     lock(_lock) {
//         Enumerable.Range(0, 10).ToList().ForEach(x => {
//             Singleton.Instance.Ecrire("t2");
//             Thread.Sleep(Random.Shared.Next(1, 50));
//         });
//     }
// });

// Console.Out.WriteLine();
// Console.Out.WriteLine("Avec lock");
// t1.Start();
// t2.Start();

// t1.Join();
// t2.Join();

HashSet<Guid> hashSet = new HashSet<Guid>();
long count = 0;
Parallel.ForEach(Enumerable.Range(0, 100_000_000),
new ParallelOptions
{
    // multiply the count because a processor has 2 cores
    MaxDegreeOfParallelism = Convert.ToInt32(Math.Ceiling((Environment.ProcessorCount * 0.75) * 2.0))
},
    x =>
    {
        Guid g = Guid.NewGuid();
        lock (_lock)
        {
            ++count;
            if (count % 1_000_000 == 0)
            {
                Console.Out.WriteLine(count/1_000);
            }
            if (hashSet.Contains(g))
            {
                Console.Out.WriteLine("Doublon " + g);
            }
            else
            {
                hashSet.Add(g);
            }
        }
    });
// for (int i = 0; i < 100_000_000; i++) {
//     Guid g = Guid.NewGuid();
//     if (dico.ContainsKey(g)) {
//         dico[g]++;
//     } else {
//         dico.Add(g, 1);
//     }
// }

//dico.Where(x => x.Value > 1).ToList().ForEach(x => Console.Out.WriteLine(x.Key + " " + x.Value));


class Singleton
{
    private static Singleton? m_instance;
    private static readonly object _lock = new object();
    private Singleton() { }
    public static Singleton Instance
    {
        get
        {
            if (m_instance == null)
            {
                lock (_lock)
                {
                    if (m_instance == null)
                    {
                        m_instance = new Singleton();
                    }
                }
            }

            return m_instance;
        }
    }

    public void Ecrire(string p_message)
    {
        Console.Out.WriteLine(p_message);
        //Console.Out.WriteLine(Guid.NewGuid().ToString());
    }
}