using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class CourseServices
    {
        public static void AddNewCourseer(string Title, int Credits)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Courses.Add(new Course
                {
                    Title = Title,
                    Credits = Credits
                });
            }
        }

        public static List<Course> GetAll()
        {
            List<Course> list = new List<Course>();

            using (LoyaltyDB db = new LoyaltyDB())
            {
                list = db.Courses.ToList();
            }

            return list;
        }

        public static void AddNew(Course Course)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Courses.Add(Course);
                db.SaveChanges();
            }
        }

        public static void Update(Course Course)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Entry(Course).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static Course FindById(int id)
        {
            Course Courseer = null;

            using (LoyaltyDB db = new LoyaltyDB())
            {
                Courseer = db.Courses.Find(id);

                if (Courseer != null)
                {
                    return Courseer;
                }
            }

            return null;
        }

        public static List<Course> FindByCourseerData(string text)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                return db.Courses.Where(x => x.Title.Contains(text)).ToList();
            }
        }
    }
}
