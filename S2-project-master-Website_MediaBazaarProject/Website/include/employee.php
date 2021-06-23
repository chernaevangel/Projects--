<?php

    class Employee 
    {
        private $id;
        private $firstName;
        private $lastName;
        private $birthDay;
        private $phoneNumber;
        private $hoursWorked;
        private $employeeType;
        private $department;
        private $email;
        private $password;
        private $yearsInCompany;
        private $shifts;

        public function __construct($id, $firstName, $lastName, $birthDay, $phoneNumber, $hoursWorked, $employeeType, $department, $email, $password, $yearsInCompany, $shifts)
        {
            $this->id = $id;
            $this->firstName = $firstName;
            $this->lastName = $lastName;
            $this->birthDay = $birthDay;
            $this->phoneNumber = $phoneNumber;
            $this->hoursWorked = $hoursWorked;
            $this->employeeType = $employeeType;
            $this->department = $department;
            $this->email = $email;
            $this->password = $password;
            $this->yearsInCompany = $yearsInCompany;
            $this->SetShifts($shifts);            
        }

        public function getId() {
            return $this->id;
        }
        public function FirstName() {
            return $this->firstName;
        }
        public function LastName() {
            return $this->lastName;
        }
        public function Birthday() {
            return $this->birthDay;
        }
        public function PhoneNumber() {
            return $this->phoneNumber;
        }
        public function HoursWorked() {
            return $this->hoursWorked;
        }
        public function EmployeeType() {
            return $this->employeeType;
        }
        public function Department() {
            return $this->department;
        }
        public function Email() {
            return $this->email;
        }
        public function Password() {
            return $this->password;
        }
        public function YearsInCompany() {
            return $this->yearsInCompany;
        }
        public function Shifts() {
            return $this->shifts;
        }

        public function SetShifts($shifts) {
            $this->shifts = null;
            if(empty($shifts))
            {
                $this->shifts = "No shifts found!";
            }
            else
            {
                $this->shifts = $shifts;
            }
        }

        public function ModifyEmployee($firstName, $lastName, $birthDay, $phoneNumber, $email) {
            $this->firstName = $firstName;
            $this->lastName = $lastName;
            $this->birthDay = $birthDay;
            $this->phoneNumber = $phoneNumber;
            $this->email = $email; 
        }

        public function __toString()
        {
            return "$this->id, $this->firstName, $this->lastName, $this->birthDay, $this->phoneNumber, $this->hoursWorked, $this->employeeType, $this->department, $this->email, $this->password, $this->yearsInCompany";
        }

    }

?>