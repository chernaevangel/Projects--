<?php

class DBHandler {
    private $host = "studmysql01.fhict.local";
    private $user = "dbi451508";
    private $pwd = "mediabazaar";
    private $dbName = "dbi451508";
    
    private function connect() {
        try
        {
            $dsn = 'mysql:host=' . $this->host .';dbname=' . $this->dbName;
            $pdo = new PDO($dsn, $this->user, $this->pwd);
            $pdo-> setAttribute(PDO::ATTR_DEFAULT_FETCH_MODE, pDO::FETCH_ASSOC);
    
            return $pdo;
        }
        catch (Exception $ex)
        {
            echo $ex->getMessage();
            return null;
        }
    }
    
    public function getUser(string $email, string $password) {
        
        try
        {
            $password = md5($password);

            $sql = "SELECT * 
            FROM employee 
            WHERE Email = :email AND Password = :password";
            $prepSql = $this->connect()->prepare($sql);
            $prepSql->bindValue(':email', $email);
            $prepSql->bindValue(':password', $password);

            $prepSql->execute();
            $result = $prepSql->fetchAll();
       
            foreach($result as $row) {
    
                $dbId = $row['Id'];
                $dbFirstName = $row['FirstName'];
                $dbLastName = $row['LastName'];
                $dbBirthday = $row['Birthday'];
                $dbPhoneNumber = $row['PhoneNumber'];
                $dbHoursWorked = $row['HoursWorked'];
                $dbEmployeeType = $row['EmployeeType'];
                $dbDepartment = $row['Department'];
                $dbEmail = $row['Email'];
                $dbPassword = $row['Password'];
                $dbYearsInCompany = $row['YearsInCompany'];
                $shifts = $this->GetShifts($dbId);
                if(!isset($dbDepartment))
                {
                    $dbDepartment = "Not applicable";
                }

                $user = new Employee($dbId, $dbFirstName, $dbLastName, $dbBirthday, $dbPhoneNumber, $dbHoursWorked, $dbEmployeeType, $dbDepartment, $dbEmail, $dbPassword, $dbYearsInCompany, $shifts);
                return $user;
            }
            return false;
        }
        catch(Exception $ex)
        {
            echo $ex->getMessage();
            return null;
        }
        finally
        {
            $connect = null;
        }
    }

    public function checkUserExists(string $email) {
        try
        {
            $sql = "SELECT * FROM employee WHERE Email = :email";
            $prepSql = $this->connect()->prepare($sql);
            $prepSql->bindValue(':email', $email);

            $prepSql->execute();
            $result = $prepSql->fetchAll();

            if(!empty($result))
            { return true; }
            else
            { return false; }
        }
        catch (Exception $ex)
        {
            echo $ex->getMessage();
            return null;
        }
        finally
        {
            $connect = null;
        }
    }

    public function registerEmployee(string $firstName, string $lastName, string $birthday, string $phoneNumber, string $employeeType, string $department, string $email, string $password) {

        try
        {
            $sql = "INSERT INTO employee (FirstName, LastName, Birthday, PhoneNumber, HoursWorked, EmployeeType, Department, Email, Password, YearsInCompany) VALUES (:firstName, :lastName, :birthDay, :phoneNumber, '0', :employeeType, :department, :email, :password, '1')";
            $preparedSql = $this->connect()->prepare($sql);
            $preparedSql->bindValue(':firstName', $firstName);
            $preparedSql->bindValue(':lastName', $lastName);
            $preparedSql->bindValue(':birthDay', $birthday);
            $preparedSql->bindValue(':phoneNumber', $phoneNumber);
            $preparedSql->bindValue(':employeeType', $employeeType);
            $preparedSql->bindValue(':department', $department);
            $preparedSql->bindvalue(':email', $email);
            $encryptPassword = md5($password);
            $preparedSql->bindValue(':password', $encryptPassword);
    
            if($this->checkUserExists($email) == false)
            { 
                $preparedSql->execute(); 
                return true;
            }
            else
            { 
                return false;
            }
        }
        catch(Exception $ex)
        {
            echo $ex->getMessage();
            return null;
        }
        finally
        {
            $connect = null;
        }
        
    }

    public function GetShifts($employeeId) {
        
        try
        {
            $sql = "SELECT * FROM shift WHERE EmployeeId = :employeeId";
            $preparedSql = $this->connect()->prepare($sql);
            $preparedSql->bindValue(":employeeId", $employeeId);
            $preparedSql->execute();
    
            $shifts = [];
    
            while($row = $preparedSql->fetch()) {
    
                $dbDate = $row['Date'];
                $dbShiftTime = $row['ShiftTime'];
                $dbId = $row['EmployeeId'];
    
                $shift = new Shift($dbDate, $dbShiftTime, $dbId);
                array_push($shifts, $shift);
            }
            return $shifts;
        }
        catch(Exception $ex)
        {
            echo $ex->getMessage();
            return null;
        }
        finally
        {
            $connect = null;
        }
    }   
    public function UpdateEmployee($employee) {
        try
        {
            $sql = "UPDATE employee 
            SET FirstName = :firstname, LastName = :lastName, Birthday = :birthday, PhoneNumber = :phoneNumber, Email = :email
            WHERE Id = :id";
            $preparedSql = $this->connect()->prepare($sql);
            $preparedSql->bindValue(':firstname', $employee->FirstName());
            $preparedSql->bindValue(':lastName', $employee->LastName());
            $preparedSql->bindValue(':birthday', $employee->Birthday());
            $preparedSql->bindValue(':phoneNumber', $employee->PhoneNumber());
            $preparedSql->bindValue(':email', $employee->Email());
            $preparedSql->bindValue(':id', $employee->getId());
            $preparedSql->execute();
            return true;
        }
        catch(Exception $ex)
        {
            echo $ex->getMessage();
            return null;
        }
        finally
        {
            $connect = null;
        }
    }

    public function GetDepartments() {
        try
        {
            $sql = "SELECT Name FROM department";
            $prepSql = $this->connect()->prepare($sql);

            $prepSql->execute();
            $result = $prepSql->fetchAll();

            $departments = [];
            foreach($result as $departmentName) {
                array_push($departments, $departmentName['Name']);
            }
            return $departments;
        }
        catch (Exception $ex)
        {
            echo $ex->getMessage();
            return null;
        }
        finally
        {
            $connect = null;
        }
    }

    public function GetEmployeeTypes() {
        try
        {
            $sql = "SELECT Type FROM employeetype";
            $prepSql = $this->connect()->prepare($sql);

            $prepSql->execute();
            $result = $prepSql->fetchAll();

            $empTypes = [];
            foreach($result as $empType) {
                array_push($empTypes, $empType['Type']);
            }
            return $empTypes;
        }
        catch (Exception $ex)
        {
            echo $ex->getMessage();
            return null;
        }
        finally
        {
            $connect = null;
        }
    }
}

?>