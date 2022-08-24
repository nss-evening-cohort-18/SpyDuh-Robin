using SpyDuh_Robin.Interfaces;
using SpyDuh_Robin.Models;

namespace SpyDuh_Robin.Repositories
{
    public class SpyRepository : ISpyRepository
    {
        private static List<Spy> _spies = new List<Spy>()
        {
            new Spy(1, "Dilophosaurus", new (){"spitting", "running", "camoflauge", "stealth"}, new(){"assassination", "intimidation", "espionage", "blackmail"}, new(){2, 3}, new(){4, 5}, "Jurassic Park", "Infidelity Observation & Potential Blackmail of Lying, Cheating, Spouse", new DateTime(2022, 12, 25 )),
            new Spy(2, "The Pink Panther", new (){"sleuthing", "stealing", "camoflauge", "stealth"}, new(){"stealing", "intimidation", "assassination", "movies"}, new(){1, 3}, new(){4, 5}, "The Red Rose", "Steal from Detective Jacques Clouseau", new DateTime(2022, 10, 31 )),
            new Spy(3, "Jar Jar Binks", new (){"intelligence", "persuasion", "athleticism", "adaptability"}, new(){"assassination", "intimidation", "espionage", "double agent"}, new(){1, 3}, new(){4, 5}, "Jurassic Park", "Kill Emperor Palpatine", new DateTime(2023, 1, 1 )),
            new Spy(4, "James Bond", new (){"intelligence", "hiding", "accuracy", "bartending"}, new(){"assassination", "womanizer", "espionage", "blackmail"}, new(){5}, new(){1, 2, 3}, "MI-6", "Abduct and Impersonate the Leader of the Free World", new DateTime(2023, 1, 1 )),
            new Spy(5, "Sirius Black", new (){"transfiguration", "spell casting", "defense against the dark arts", "stealth"}, new(){"espionage", "intimidation", "tracking", "blackmail"}, new(){4}, new(){1, 2, 3}, "The Order of the Phoenix", "Steal the Sword of Gryffindor from Bellatrix LeStrange", new DateTime(2022, 10, 31 ))
        };

        public void Post(Spy spy)
        {
            _spies.Add(spy);
        }

        public List<Spy> GetAll()
        {
            return _spies;
        }

        public List<Spy> GetBySkill(string skill)
        {
            return _spies.Where(spySkill => spySkill.Skills.Contains(skill)).ToList();

        }

        public List<Spy> GetByFriend(int friend)
        {
            return _spies.Where(spyFriend => spyFriend.Friends.Contains(friend)).ToList();
        }

        public void AddService(int id, List<string> value)
        {
            var index = _spies.IndexOf(_spies.FirstOrDefault(u => u.Id == id));
            _spies[index].Services.AddRange(value);
            
        }

        public void AddSkill(int id, List<string> value)
        {
            var index = _spies.IndexOf(_spies.FirstOrDefault(u => u.Id == id));
            _spies[index].Skills.AddRange(value);

        }
    }

   
    };

