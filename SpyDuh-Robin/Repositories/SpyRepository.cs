using SpyDuh_Robin.Interfaces;
using SpyDuh_Robin.Models;
using System.Net;

namespace SpyDuh_Robin.Repositories
{
    public class SpyRepository : ISpyRepository
    {
        private static List<Spy> _spies = new List<Spy>()
        {
            new Spy(1, "Dilophosaurus", new (){"spitting", "running", "camoflauge", "stealth"}, new(){"assassination", "intimidation", "espionage", "blackmail"}, new(){2, 3}, new(){2, 4, 5}, "Jurassic Park", "Infidelity Observation & Potential Blackmail of Lying, Cheating, Spouse", new DateTime(2022, 12, 25 )),
            new Spy(2, "The Pink Panther", new (){"sleuthing", "stealing", "camoflauge", "stealth"}, new(){"stealing", "intimidation", "assassination", "movies"}, new(){1, 3}, new(){4, 5, 3}, "The Red Rose", "Steal from Detective Jacques Clouseau", new DateTime(2022, 10, 31 )),
            new Spy(3, "Jar Jar Binks", new (){"intelligence", "persuasion", "athleticism", "adaptability"}, new(){"assassination", "intimidation", "espionage", "double agent"}, new(){1, 3}, new(){4, 5}, "Jurassic Park", "Kill Emperor Palpatine", new DateTime(2023, 1, 1 )),
            new Spy(4, "James Bond", new (){"intelligence", "hiding", "accuracy", "bartending"}, new(){"assassination", "womanizer", "espionage", "blackmail"}, new(){5}, new(){1, 2, 3}, "MI-6", "Abduct and Impersonate the Leader of the Free World", new DateTime(2023, 1, 1 )),
            new Spy(5, "Sirius Black", new (){"transfiguration", "spell casting", "defense against the dark arts", "stealth"}, new(){"espionage", "intimidation", "tracking", "blackmail"}, new(){1, 2, 3}, new(){1, 2, 3}, "The Order of the Phoenix", "Steal the Sword of Gryffindor from Bellatrix LeStrange", new DateTime(2022, 10, 31 ))
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
            skill = skill.ToLower();
            return _spies.Where(spySkill => spySkill.Skills.Contains(skill)).ToList();

        }

        public List<Spy> GetByFriend(int friend)
        {
            return _spies.Where(spyFriend => spyFriend.Friends.Contains(friend)).ToList();
        }
        public List<Spy> GetByEnemy(int enemy)
        {
            List<Spy> ContainsEnemies = _spies.Where(spyEnemy => spyEnemy.Enemies.Contains(enemy)).ToList();
            int index = _spies.IndexOf(_spies.FirstOrDefault(s => s.Id == enemy));
            List<int> EnemiesList = _spies[index].Enemies;
            List<Spy> Enemies = _spies.Where(spy => EnemiesList.Contains(spy.Id)).ToList();
            foreach (Spy s in Enemies)
            {
                if (!ContainsEnemies.Contains(s))
                    {
                    ContainsEnemies.Add(s);
                    }
            }

            return ContainsEnemies;

        }

        public List<Spy> GetByFriendofFriend(int friend) //enter 1
        {
            int index = _spies.IndexOf(_spies.FirstOrDefault(s => s.Id == friend)); //grabs person 1's friends, which are 2 & 3
            List<int> SpyFriends = _spies[index].Friends; //contains 2 & 3
            HashSet<int> FriendsofFriends = new HashSet<int>(); //should grab 1 & 3
            foreach(Spy spy in _spies)
            {
                if (SpyFriends.Contains(spy.Id))
                {
                    foreach(int s in spy.Friends)
                    {
                        FriendsofFriends.Add(s); //added 1 & 3 to FriendsofFriends List
                    }
                }
            }
            List<Spy> FriendsofFriendsSpies = _spies.Where(spyFriend => FriendsofFriends.Contains(spyFriend.Id)).ToList();
            return FriendsofFriendsSpies;
        }

        public List<Spy> GetAgency(string agency)
        {
            return _spies.Where(spy => spy.AgencyName == agency).ToList();
        }

        public int GetByDueDate(int id)
        {
            var index = _spies.IndexOf(_spies.FirstOrDefault(s => s.Id == id));
            var dueDate = _spies[index].AssignmentDueDate;
            var currentDate = DateTime.Now;
            return (int)(dueDate - currentDate).TotalDays;
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

        public string removeSkill(int id, string skill)
        {
            int index = _spies.IndexOf(_spies.FirstOrDefault(x => x.Id == id));
            if (index == -1 || !_spies[index].Skills.Contains(skill)) {
                //throw new StatusCodeException(HttpStatusCode.NotFound);
                return "either the user or skill does not exist"; 
            }
            _spies[index].Skills.Remove(skill);
            return "success";
        }

        public string removeService(int id, string service)
        {
            int index = _spies.IndexOf(_spies.FirstOrDefault(x => x.Id == id));
            if (index == -1 || !_spies[index].Services.Contains(service))
            {
                //throw new StatusCodeException(HttpStatusCode.NotFound);
                return "either the user or skill does not exist";
            }
            _spies[index].Services.Remove(service);
            return "success";
        }

    }
};

