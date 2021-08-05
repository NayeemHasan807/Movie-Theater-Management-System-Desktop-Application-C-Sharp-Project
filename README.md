# Movie-Theater-Management-System-Desktop-Application-C-Sharp-Project

# Contributors:
• Nayeem Hasan Moon
• Sumaiya Rahman Eva
• Sumaiya Sultana

# Project Feature List:
•	User_1: Manager 
o	As a user of the system, he can sign-in.
o	He can manage employee and do CRUD operation.
o	He can also use all the features of cashier and other employees. 

•	User_2: Cashier
o	As a user of the system, he can sign-in.
o	He can book tickets for customer and do CRUD operation.
o	He can manage movie shows and do CRUD operation.
o	He can manage payment and bills for customer.

•	User_3: Other Employee
o	As a user of the system, they can sign-in;
o	They can change their password.
o	They can see their information.

# Entities and attributes:
•	Entity: User
o	Id [Int]
o	UserId [string]
o	UserPassword [string]
o	UserStatus [string]

•	Entity: Employee
o	Id [Int]
o	EmployeeId [string]
o	EmployeeName [string]
o	JobCategory [string]
o	Salary [double]
o	EmployeePhoneNo [string]
o	JoiningDate [Datetime]
o	EmployeeEmail [string]

•	Entity: Movie             
o	Id [Int]
o	MovieId [string]
o	MovieName [string]
o	MovieLanguage [string]
o	MovieHour [string]
o	MovieType [string]
o	MovieDate [Datetime]

•	Entity: Seat
o	Id [Int]
o	MovieId [string]
o	S101 [string]
o	S102 [string]
o	S103 [string]
o	S104 [string]
o	S105 [string]
o	S106 [string]
o	S107 [string]
o	S108 [string]
o	S109 [string]
o	S110 [string]

•	Entity: Booking
o	Id [Int]  
o	TicketId [string]
o	MemberOrCustomerId [string]
o	MovieId [string]
o	MovieName [string]
o	BookingDate [Datetime]
o	BookingTime[string]
o	SeatNumber [string]

•	Entity: Member
o	Id[Int]            
o	MemberId [string]
o	MemberName [string]
o	MemberPhoneNumber[string]
o	RewardPoint[Int]
o	MemberEmail[string]

•	Entity: Customer
o	Id [Int]
o	CustomerId [string]
o	CustomerName [string]
o	CustomerPhoneNo [string]

•	Entity: Payment
o	Id [Int]
o	PaymentId [string]
o	TicketId[string]
o	MemberOrCustomerId [string]
o	MemberOrCustomerName [string]
o	Amount [double]
o	PaymentDate [Datetime]
o	PaymentTime [string]
