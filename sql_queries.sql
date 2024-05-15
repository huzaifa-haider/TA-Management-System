create table credential(
username varchar(100) primary key,
password varchar(100),
type varchar(50)
);
select* from credential


create table  employee(
id varchar(100) primary key,
name varchar(100),
contact varchar(50),
email varchar(100),
type varchar(50)
);


alter table employee
add username varchar(100) foreign key references credential(username)

select* from student


select* from employee

drop table employee
select* from employee

create table  course(
course_code varchar(50) primary key,
title varchar(200),
cr_hrs int,
);
select* from course

alter table course
add employee_id varchar(100) foreign key references employee(id)



create table  application(
id int IDENTITY(1,1) primary key,
status bit,
student_id varchar(50) foreign key references student(id),
employee_id varchar(100) foreign key references employee(id),
);



create table  offered_course(
instructor varchar(100),
section_id varchar(50)

);

create table  task(
task_id int IDENTITY(1,1) primary key,
name varchar(100),
description varchar(200),
student_id varchar(50) foreign key references student(student_id),
employee_id varchar (100) foreign key references employee(employee_id),
course_code varchar(50) foreign key references course(course_code)
);


ALTER TABLE task
ADD Done BIT;






create table  feed_back(
id int primary key,
rating int,
description varchar(200)

);
create table  student(
id varchar(50) primary key,
name varchar(100),
dept varchar(100),
task_count int
);

create table  payment(
id int primary key,
amount int,
student_id varchar(50) foreign key references student(id)

);

insert into student values('21i-0784','Huzaifa Haider',
'CS','fifth semester','i210784@nu.edu.pk',
'0343-0473955','A+',null,null);
insert into employee values('amir.rehman','Amir Rehman','03431234567','amir.rehman@nu.edu.pk','admin')
insert into employee values('ifrah.qaiser','Ifrah Qaiser','03431234567','ifrah.qaiser@nu.edu.pk','faculty')
insert into employee values('hammad.majeed','Hammad Majeed','03431234567','hammad.majeed@nu.edu.pk','hod');
insert into credential values('hammad.majeed','hammad123','hod');
insert into credential values('ifrah.qaiser','ifrah123','faculty');
insert into credential values('amir.rehman','amir123','admin');
insert into credential values('21i-0784','huzaifa123','student');
----------------------------------Many to Many table -----------------------------------
create table employee_has_students(
student_id varchar(50),
employee_id varchar(100),
primary key(student_id,employee_id),
foreign key (student_id) references student(student_id),
foreign key (employee_id) references employee(employee_id)
);


insert into employee_has_students values('21i-0784','ifrah.qaiser')

select* from employee_has_students


create table student_select_course(
student_id varchar(50),
course_code varchar(50),
primary key(student_id,course_code),
foreign key (student_id) references student(student_id),
foreign key (course_code) references course(course_code)
);

create or alter procedure insertDataTask  @t_name varchar(100),@desc varchar(200),@student_id varchar(50),@employee_id varchar(100) ,@course_code varchar(50)
as 
begin
insert into task values(@t_name,@desc,@student_id,@employee_id,@course_code);
end

exec insertDataTask @t_name='quiz1',@desc='mark this quiz',@student_id='21i-0784',@employee_id='ifrah.qaiser',@course_code='CS-1002'

select* from task

create or alter procedure insertDataApplication  @status bit,@student_id varchar(50),@employee_id varchar(100),
@contact varchar(20),@qualification varchar(50),@email varchar(100),@grade varchar(2),@type varchar(2)
as 
begin
insert into application values(@status,@student_id,@employee_id,@contact,@qualification,@email,@grade,@type);
end

exec insertDataApplication  @status=0 ,@student_id='19i-0563',@employee_id =null,@contact= '02222222',@qualification= '5th',@email= 'i210784@nu.edu.pk',@grade= 'A',@type='LD';

select* from student
-----------------------------------------------UPDATE------------------------------------

UPDATE application SET qualification = 'new qual', contact='new contact' WHERE student_id ='21i-0784' ;

------------------------------------------------------------------------------------------

select  s.student_id,name,s.dept,a.status,a.employee_id,a.contact,a.qualification,a.email,a.grade
                from student as s inner join application as a on a.student_id=a.student_id 



				
select  s.student_id ,ssc.course_code,name,s.dept,a.status,a.employee_id,a.contact,a.qualification,a.email,a.grade
                from student as s inner join application as a on a.student_id=a.student_id 
				inner join student_select_course as ssc on ssc.student_id=s.student_id


select  s.student_id ,ssc.course_code,s.name,s.dept,a.status,a.employee_id,a.contact,a.qualification,a.email,a.grade from student as s inner join application as a on s.student_id=a.student_id inner join student_select_course as ssc on ssc.student_id=s.student_id;


select ehs.student_id as student_id from employee_has_students as ehs inner join application as a on a.student_id=ehs.student_id
EXEC sp_rename 'employee.id', 'employee_id', 'COLUMN';
EXEC sp_rename 'application.id', 'application_id', 'COLUMN';

EXEC sp_rename 'task.id', 'task_id', 'COLUMN';

EXEC sp_rename 'feed_back.id', 'feed_back_id', 'COLUMN';

create or alter procedure insertIntoCredential @username varchar(100) , @password varchar(100),@type varchar(50)
as 
begin
insert into credential values(@username,@password,@type);
end

-------------------------------------------------------------Auto insert data---------------------------------
CREATE TRIGGER changeUserUpdateCredentialTgr
ON student
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Credential (username, password, type) values(stdID,stdPass,'type is student')
    SELECT student_id as stdID,student as stdPass 
    FROM inserted;
END



CREATE TRIGGER changeStudentUpdateStudentSelectTgr
ON student
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO studstudent_select_course(username, password, type)
    SELECT student_id, student_id, 'student'
    FROM inserted;
END;

insert into student_select_course(student_id,course_code) values(,);
--2222222222222222222222
insert into student_select_course(student_id) values('21i-0416')


CREATE TRIGGER changeUserUpdateCredentialTgr
ON student
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Credential (username, password, type)
    SELECT student_id, student_id, 'student'
    FROM inserted;
END;

CREATE TRIGGER changeEmpUpdateCredTgr
ON employee
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Credential (username, password, type)
    SELECT employee_id, employee_id, type
    FROM inserted;
END;



insert into employee values ('naveed.ahmad','Dr. Naveed Ahmad','0343434343434','naveed.ahmad@nu.edu.pk','faculty',null);

insert into employee values ('muhmmad.fahad','Muhammad Fahad','0343434343434','muhmmad.fahad@nu.edu.pk','admin',null);

--------------------------------------------student data insertion ----------------------------------
INSERT INTO student
SELECT *  [dbo].[studentDataCSV]
 
 -----------------------------------------------------------------------------------------------------



CREATE or alter FUNCTION CheckValueExists(
    @key VARCHAR(100)
)
RETURNS BIT
AS
BEGIN
    DECLARE @Exists BIT;

    IF EXISTS (SELECT 1 FROM course WHERE course_code = @key)
        SET @Exists = 1;
    ELSE
        SET @Exists = 0;

    RETURN @Exists;
END;




select dbo.CheckValueExists('CS-1002');
	

select* from student

alter table application
add type varchar(2) 

select* from application

exec insertDataApplication  @status=0 ,@student_id='',@employee_id =null,@contact= '" + contact + "',@qualification= '" + qualification + "',@email= '" + qualification + "',@grade= '" + grade + "';


create table employee_teaches_course(
employee_id varchar(100),
course_code varchar(50),
primary key(employee_id,course_code),
foreign key (employee_id) references employee(employee_id),
foreign key (course_code) references course(course_code)
);

delete employee_teaches_course
select * from employee_teaches_course

alter table student
add type varchar(2) 



create table admin(

employee_id varchar(100),
primary key(employee_id),
foreign key (employee_id) references employee(employee_id)

);


create table faculty(

employee_id varchar(100),
primary key(employee_id),
foreign key (employee_id) references employee(employee_id)

);


select* from employee_teaches_course



select* from [dbo].[courseDataCSV]

delete  course
course(course_code)
select * from course

delete student_select_course

select* from application

delete application

select* from course


select course_code,employee_id from [dbo].[courseDataCSV]
group by course_code

SELECT course_code, employee_id AS total_credit_hours
FROM [dbo].[courseDataCSV]
GROUP BY course_code;

select* from [dbo].[courseDataCSV]


SELECT course_code, MIN(employee_id)  as employee_id, MIN(name) as name,MIN(email) as email
FROM [dbo].[courseDataCSV]
GROUP BY course_code;

select* from employee


select course_code [dbo].[courseDataCSV]


select* from employee
select* from [dbo].[courseDataCSV]

select* from credential
insert into credential(username) values('NULL')

select* from employee
select* from [dbo].[courseDataCSV]

select* from course

insert into course(course_code,title,cr_hrs)
select distinct course_code, title,cr_hrs
from [dbo].[courseDataCSV]

select course_code from course
select * from employee 

insert into employee_teaches_course values ('ifrah.qaiser','CS-3006')
insert into employee_teaches_course values ('maryam.shahbaz','CS-3009')
insert into employee_teaches_course values ('naveed.ahmad','CS-3015')





ALTER task
add  task_id INT IDENTITY(1,1);

alter table task
add column status bit

insert into employee_has_students

select* from employee_has_students

insert into employee_has_students values('21i-0784','ifrah.qaiser')

select top(1) student_id from student



select* from employee_has_students
select* from application

select employee_id from employee_teaches_course where course_code='CS-3006'


select* from application


--@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@		Nested Quries		@@@@@@@@@@@@@@@@@@@@@@@@@@@

--Nested Query to Get Employees with Application Status:

SELECT id, name, type
FROM employee
WHERE username IN (SELECT employee_id FROM application WHERE status = 1);


--Nested Query to Get Students with Incomplete Tasks:

SELECT student_id, name, task_count
FROM student
WHERE student_id IN (SELECT student_id FROM task WHERE Done = 0);


--Nested Query to Get Courses Offered by a Specific Instructor:

SELECT course_code, title, cr_hrs
FROM course
WHERE employee_id IN (SELECT employee_id FROM employee WHERE name = 'ifrah.qaiser');

select* from feed_back

-----------
SELECT feed_back_id, rating, description
FROM feed_back
WHERE employee_id IN (SELECT employee_id FROM employee WHERE type ='faculty');


--