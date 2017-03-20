# Wonde .NET Client
Documentation https://wonde.com/docs/api/1.0/

## Installation

Target .Net Framework 4.6.1

Using Nuget:

```Nuget Package Manager Console
Not yet added to Nuget.org
```

## Endpoints

### Client

```C#
var client = new Wonde.Client("TOKEN_GOES_HERE");
```
```VB
Dim client as New Wonde.Client("TOKEN_GOES_HERE")
```


### Schools

```C#
$client = new Wonde.Client("TOKEN_GOES_HERE");

// Loop through the schools your account has access to
foreach (Dictionary<string, object> school in client.schools.all()) {
    // Display school name
    Console.WriteLine("School's name is {0}, school["name"]);
}

```
```VB
Dim client as New Wonde.Client("TOKEN_GOES_HERE")

//Loop through the schools your account has access to
For Each school as Dictionary(of String, Object) in client.schools.all()
	//Display school name
	Console.WriteLine("School's name is {0}, school("name"))
Next school

```

### Single School

```C#
var client = new Wonde.Client("TOKEN_GOES_HERE");

// Get single school
var school = client.schools.get('SCHOOL_ID_GOES_HERE');
```
```VB
Dim client as New Wonde.Client("TOKEN_GOES_HERE")

// Get single school
Dim school As Variant
school = client.schools.get('SCHOOL_ID_GOES_HERE')
```

### Pending Schools

```C#
var client = new Wonde.Client("TOKEN_GOES_HERE");

foreach (Dictionary<string, object> school in client.schools.pending()) {
    // Display school name
    Console.WriteLine("Pending School name {0}", school["name"]);
}
```
```VB
Dim client as New Wonde.Client("TOKEN_GOES_HERE")

For Each school as Dictionary(of String, Object) in client.schools.pending()
    // Display school name
    Console.WriteLine("Pending School name {0}", school("name"))
Next school
```

### Search Schools

```C#
var client = new Wonde.Client("TOKEN_GOES_HERE");

// Search for schools with a postcode starting CB21
var params = new Dictionary<string, string>();
params.Add("postcode", "CB21");
foreach (Dictionary<string, object> school in client.schools.search(null, params)) {
    // Display school name
    Console.WriteLine("School searched is {0}", school[name]);
}

// Search for schools with the establishment number = 6006
params.Clear();
params.Add("establishment_number", "6006");
foreach (Dictionary<string, object> school in client.schools.search(null, params)) {
    // Display school name
    Console.WriteLine("School searched is {0}", school[name]);
}
```
```VB
Dim client As New Wonde.Client("TOKEN_GOES_HERE")

'Search for schools with a postcode starting CB21
Dim params = New Dictionary(Of String, String)
params.Add("postcode", "CB21")
For Each school As Dictionary(Of String, Object) In client.schools.search(Nothing, params)
	'Display school name
	Console.WriteLine("School searched is {0}", school("name"))
Next school

'Search for schools with the establishment number = 6006
params.Clear()
params.Add("establishment_number", "6006")
For Each school As Dictionary(Of String, Object) In client.schools.search(Nothing, params)
	'Display school name
	Console.WriteLine("School searched is {0}", school("name"))
Next school
```

### Request Access

Provide the school ID to request access to a school's data.

```C#
var client = new Wonde.Client("TOKEN_GOES_HERE");
client.requestAccess('A0000000000');
```
```VB
Dim client As New Wonde.Client("TOKEN_GOES_HERE")
client.requestAccess('A0000000000')
```

### Revoke Access

Provide the school ID to access already approve or pending approval.

```C#
var client = new Wonde.Client("TOKEN_GOES_HERE");
client.revokeAccess('A0000000000');
```
```VB
Dim client As New Wonde.Client("TOKEN_GOES_HERE")
client.revokeAccess('A0000000000')
```

### Students

```C#
var client = new Wonde.Client("TOKEN_GOES_HERE");

var school = client.school("SCHOOL_ID_GOES_HERE");

// Get students
foreach (Dictionary<string, object> kv in school.students.all())
{
	Console.WriteLine("Student's Name is {0} {1}", kv["forename"], kv["surname"]);
}


// Get single student
var student = school.students.get('STUDENT_ID_GOES_HERE');

// Get students and include contact_details object
foreach (Dictionary<string, object> kv in school.students.all(new string[] { "contact_details" }))
{
	Console.WriteLine("Student's Name is {0} {1}", kv["forename"], kv["surname"]);
}

// Get students and include contacts array
foreach (Dictionary<string, object> kv in school.students.all(new string[] { "contacts" })) {
	Console.WriteLine("Student's Name is {0} {1}", kv["forename"], kv["surname"]);
}

// Get students, include contact_details object, include extended_details object and filter by updated after date
var param = new Dictionary<string, string>();
param.Add("updated_after", "2016-06-24 00:00:00");
foreach (Dictionary<string, object> kv in school.students.all(new string[] { "contact_details", "extended_details" }, param))
{
	Console.WriteLine("Student's Name is {0} {1}", kv["forename"], kv["surname"]);
}
```
```VB
Dim client As New Wonde.Client("TOKEN_GOES_HERE")

Dim school = client.school("SCHOOL_ID_GOES_HERE");

' Get students
For Each kv As Dictionary(Of String, Object) In school.students.all()
	Console.WriteLine("Student's Name is {0} {1}", kv("forename"), kv("surname"));
Next kv

' Get single student
Dim student = school.students.get("STUDENT_ID_GOES_HERE")

' Get students And include contact_details object
For Each kv As Dictionary(Of String, Object) In school.students.all(New String() {"contact_details"})
	Console.WriteLine("Student's Name is {0} {1}", kv("forename"), kv("surname"))
Next kv

' Get students And include contacts array
For Each kv As Dictionary(Of String, Object) In school.students.all(New String() {"contacts"})
	Console.WriteLine("Student's Name is {0} {1}", kv("forename"), kv("surname"))
Next kv

' Get students, include contact_details object, include extended_details object And filter by updated after date
Dim param As New Dictionary(Of String, String)
param.Add("updated_after", "2016-06-24 00:00:00")
For Each kv As Dictionary(Of String, Object) In school.students.all(New String() {"contact_details", "extended_details"}, param))
	Console.WriteLine("Student's Name is {0} {1}", kv("forename"), kv("surname"))
Next kv
```

### Achievements

```C#
var client = new Wonde.Client("TOKEN_GOES_HERE");

var school = client.school("SCHOOL_ID_GOES_HERE");

// Get achievements
foreach (Dictionary<string, object> achievement in school.achievements.all()) {
    Console.WriteLine("Comment: {0}", achievement["comment"]);
}
```
```VB
Dim client As New Wonde.Client("TOKEN_GOES_HERE")

Dim school = client.school("SCHOOL_ID_GOES_HERE");

' Get achievements
For Each achievement As Dictionary(Of String, Object) In school.achievements.all()
	Console.WriteLine("Comment: {0}", achievement("comment"))
Next achievement
```

### Assessment - (BETA)
This endpoint is included in the stable release but is likely to change in the future. Please contact support for more information.

```C#
var client = new Wonde.Client("TOKEN_GOES_HERE");

var school = client.school("SCHOOL_ID_GOES_HERE");

// Get aspects
foreach (Dictionary<string, object> aspect in school.assessment.aspects.all()) {
    Console.WriteLine("Aspect ID: {0}", aspect["id"]);
}

// Get templates
foreach (Dictionary<string, object> template in school.assessment.templates.all()) {
    Console.WriteLine("Template ID: {0}", template["id"]);
}

// Get result sets
foreach (Dictionary<string, object> resultset in school.assessment.resultsets.all()) {
    Console.WriteLine("ResultSet ID: {0}", resultset["id"]);
}

// Get results 
foreach (Dictionary<string, object> result in school.assessment.results.all()) {
    Console.WriteLine("Result ID: {0}", result["id"]);
}

// Get marksheets
foreach (Dictionary<string, object> marksheet in school.assessment.marksheets.all()) {
    Console.WriteLine("Marksheet ID: {0}", marksheet["id"]);
}
```
```VB
Dim client As New Wonde.Client("TOKEN_GOES_HERE")

Dim school = client.school("SCHOOL_ID_GOES_HERE");

' Get aspects
For Each aspect As Dictionary(Of String, Object) In school.assessment.aspects.all()
	Console.WriteLine("Aspect ID: {0}", aspect("id"))
Next aspect

' Get templates
For Each template As Dictionary(Of String, Object) In school.assessment.templates.all()
	Console.WriteLine("Template ID: {0}", template("id"))
Next template

' Get result sets
For Each resultset As Dictionary(Of String, Object) In school.assessment.resultsets.all()
	Console.WriteLine("ResultSet ID: {0}", resultset("id"))
Next resultset

' Get results 
For Each result As Dictionary(Of String, Object) In school.assessment.results.all()
	Console.WriteLine("Result ID: {0}", result("id"))
Next result

' Get marksheets
For Each marksheet As Dictionary(Of String, Object) In school.assessment.marksheets.all()
	Console.WriteLine("Marksheet ID: {0}", marksheet("id"))
Next marksheet
```

### Attendance

```C#
var client = new Wonde.Client("TOKEN_GOES_HERE");

var school = client.school("SCHOOL_ID_GOES_HERE");

// Get attendance
foreach (Dictionary<string, object> attendance in school.attendance.all()) {
    Console.WriteLine("Attendance Comment: {0}", attendance["comment"]);
}
```
```VB
Dim client As New Wonde.Client("TOKEN_GOES_HERE")

Dim school = client.school("SCHOOL_ID_GOES_HERE");

' Get attendance
For Each attendance As Dictionary(Of String, Object) In school.attendance.all()
	Console.WriteLine("Attendance Comment: {0}", attendance("comment"))
Next attendance
```

### POST Attendance

```php
var client = new Wonde.Client("TOKEN_GOES_HERE");

// Initiate a new register
var register = new Wonde.Writeback.SessionRegister();

// Initiate a new attendance record
var attendance = new Wonde.Writeback.SessionAttendanceRecord();

// Set fields
attendance.setStudentId('STUDENT_ID_GOES_HERE');
attendance.setDate('2017-01-01');
attendance.setSession(Session.AM); // AM or PM
attendance.setAttendanceCodeId('ATTENDANCE_CODE_ID_GOES_HERE');
attendance.setComment('Comment here.');

// Add attendance mark to register
register.add(attendance);

// Save the session register
var result = school.attendance.sessionRegister(register);

// Writeback id is part of the response
Console.WriteLine ("Writeback id: {0}", result["writeback_id"]);
```
```VB
Dim client As New Wonde.Client("TOKEN_GOES_HERE")

' Initiate a new register
Dim register As new Wonde.Writeback.SessionRegister()

' Initiate a new attendance record
Dim attendance As new Wonde.Writeback.SessionAttendanceRecord()

' Set fields
attendance.setStudentId("STUDENT_ID_GOES_HERE")
attendance.setDate("2017-01-01") ' y-m-d format
attendance.setSession(Session.AM) ' AM or PM
attendance.setAttendanceCodeId("ATTENDANCE_CODE_ID_GOES_HERE")
attendance.setComment("Comment here.")

' Add attendance mark to register
register.add(attendance)

' Save the session register
Dim result = school.attendance.sessionRegister(register)

' Writeback id is part of the response
Console.WriteLine ("Writeback id: {0}", result("writeback_id"))
```


This is not completed yet.