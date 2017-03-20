using System;
using Wonde.Exceptions;

namespace Wonde.WriteBack
{
    public class LessionAttendanceRecord
    {
        /// <summary>
        /// Store student id
        /// </summary>
        public string student_id { get; private set; }

        /// <summary>
        /// Store lession id
        /// </summary>
        public string lesson_id { get; private set; }

        /// <summary>
        /// store attendance code if
        /// </summary>
        public string attendance_code_id { get; private set; }

        /// <summary>
        /// Set student id
        /// </summary>
        /// <param name="studentId">Student id in string format</param>
        public void setStudentId(string studentId)
        {
            if (studentId.Trim().Length <= 0)
            {
                throw new InvalidLessonAttendanceException("Student id can not be set to null.");
            }

            student_id = studentId;
        }

        /// <summary>
        /// Set lession id
        /// </summary>
        /// <param name="lessonId">Lession id in string format</param>
        public void setLessonId(string lessonId)
        {
            if (lessonId.Trim().Length <= 0)
            {
                throw new InvalidLessonAttendanceException("Lesson id can not be set to null.");
            }

            lesson_id = lessonId;
        }

        /// <summary>
        /// Set attendance code id
        /// </summary>
        /// <param name="attendanceCodeId">Attendance code id in string format</param>
        public void setAttendanceCodeId(string attendanceCodeId)
        {
            if (attendanceCodeId.Trim().Length <= 0)
            {
                throw new InvalidLessonAttendanceException("Attendance code id can not be set to null.");
            }

            attendance_code_id = attendanceCodeId;
        }

        /// <summary>
        /// Checks if all attributes are set
        /// </summary>
        /// <returns>returns if all fine</returns>
        public bool isValid()
        {
            return student_id.Trim().Length > 0 && lesson_id.Trim().Length > 0 && attendance_code_id.Trim().Length > 0;
        }
    }
}
