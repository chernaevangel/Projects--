<?php
    class Shift {
        private $date;
        private $shiftStart;
        private $shiftEnd;
        private $employeeId;

        public function __construct($date, $shiftTime, $employeeId)
        {
            $time = strtotime($date);
            $this->date = date('Y-m-d l', $time);
            
            $this->shiftTime = $shiftTime;
            $this->employeeId = $employeeId;
        }

        public function Date() {
            return "$this->date";
        }
        public function ShiftTime() {
            return "$this->shiftTime";
        }
        public function Id() { 
            return "$this->employeeId";
        }

        public function __toString()
        {
            return "$this->date, $this->shiftTime";
        }

    }
?>