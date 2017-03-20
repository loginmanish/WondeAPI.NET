using System;
using Wonde.Exceptions;

namespace Wonde.WriteBack
{
    public enum Session
    {
        AM,
        PM
    }

    public class SessionAttendanceRecord
    {
        /// <summary>
        /// Gets the student id string
        /// </summary>
        public string student_id { get; private set; }

        /// <summary>
        /// Gets the date string
        /// </summary>
        public string date { get; private set; }

        /// <summary>
        /// Gets the session string
        /// </summary>
        public string session { get; private set; }

        /// <summary>
        /// Gets the attendance code id string
        /// </summary>
        public string attendance_code_id { get; private set; }

        /// <summary>
        /// Gets the comment string
        /// </summary>
        public string comment { get; private set; }

        /// <summary>
        /// Sets the student id
        /// </summary>
        /// <param name="studentId">String student id</param>
        /// <exception cref="InvalidSessionAttendanceException" />
        public void setStudentId(string studentId)
        {
            if (studentId.Trim().Length <= 0)
            {
                throw new InvalidSessionAttendanceException("Student id can not be set to null.");
            }

            student_id = studentId;
        }

        /// <summary>
        /// Sets the date
        /// </summary>
        /// <param name="date">date in string</param>
        /// <exception cref="InvalidSessionAttendanceException" />
        public void setDate(string dateString)
        {
            if (dateString.Trim().Length <= 0)
            {
                throw new InvalidSessionAttendanceException("Date can not be set to null.");
            }

            DateTime time;
            if(DateTime.TryParseExact(dateString, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out time))
            {
                this.date = time.ToString("yyyy-MM-dd");
            }
            else 
            {
                throw new InvalidSessionAttendanceException("Date provided is invalid");
            }
        }

        /// <summary>
        /// Sets the session
        /// </summary>
        /// <param name="sessionString">Session String AM or PM</param>
        /// <exception cref="InvalidSessionAttendanceException" />
        public void setSession(Session session)
        {
            if(session == Session.AM || session == Session.PM)
            { 
                this.session = session.ToString();
            } 
            else 
            {
                throw new InvalidSessionAttendanceException("The session is invalid");
            }
        }


        /// <summary>
        /// Set attendance code id
        /// 
        /// Attendance codes can be fetched from the attendance-code endpoint
        /// </summary>
        /// <param name="attendanceCodeId"></param>
        /// <exception cref="InvalidSessionAttendanceException" />
        public void setAttendanceCodeId(string attendanceCodeId)
        {
            if (attendanceCodeId.Trim().Length <= 0)
            {
                throw new InvalidSessionAttendanceException("Attendance code id can not be set to null.");
            }

            attendance_code_id = attendanceCodeId;
        }

        /// <summary>
        /// Sets the comment
        /// </summary>
        /// <param name="comment">comment string</param>
        public void setComment(string comment)
        {
            this.comment = comment.Trim();
        }

        /// <summary>
        /// Check if all values are set
        /// </summary>
        /// <returns>Check result in boolean</returns>
        public bool isValid()
        {
            return date.Trim().Length > 0 && student_id.Trim().Length > 0 && session.Trim().Length > 0 && attendance_code_id.Trim().Length > 0;
        }
        
    }
}
