# QuizOOP-LVLUPV2
นาย ณัฐวุฒฺิ จันทร์สนิท 673450036-4
 ****![image](https://github.com/user-attachments/assets/913e833f-c5de-4d77-8801-92938bea2c21)

1. Major (Enumeration)
ใช้สำหรับกำหนดสาขาวิชาที่อาจารย์และนักศึกษาสังกัด

ค่าใน Enum:
Architecture
Art
Business
ComputerScience
🔷 2. DataMajor (Base Class)
คลาสพื้นฐานสำหรับนักศึกษาและอาจารย์

Properties:
name (string) → ชื่อของบุคคล
Major (enum Major) → สาขาวิชาที่เกี่ยวข้อง
🔷 3. Student (Derived from DataMajor)
คลาสสำหรับนักศึกษา

Properties:
SAS (enum Student_advisor_ForStudent) → ที่ปรึกษาของนักศึกษา
ST_ID (string) → รหัสนักศึกษา
Gpx (double) → เกรดเฉลี่ยสะสม
Name (string) → ชื่อนักศึกษา
Major (Major) → สาขาวิชาของนักศึกษา
Advisor (Teacher) → อาจารย์ที่ปรึกษา
Constructor:
ไม่มีพารามิเตอร์
🔷 4. Student_advisor_ForStudent (Enumeration - Inside Student Class)
ใช้กำหนดชื่ออาจารย์ที่ปรึกษาที่นักศึกษาสามารถเลือกได้

ค่าใน Enum:
Dr_Bob
Dr_ProntJohndan
Dr_Jin
Dr_Linda
🔷 5. Teacher (Derived from DataMajor)
คลาสสำหรับอาจารย์

Properties:
Name (string) → ชื่ออาจารย์
Students (List<Student>) → รายชื่อนักศึกษาที่อยู่ภายใต้การดูแล
Subject1 (string) → วิชาที่อาจารย์สอน
Subject2 (string) → วิชาเพิ่มเติมที่อาจารย์สอน
Constructor:
รับพารามิเตอร์: name, subject1, subject2
🔗 ความสัมพันธ์ระหว่างคลาส
📌 Student และ Teacher สืบทอดจาก DataMajor (Inheritance)
📌 Student มี Advisor (Teacher) → Association (นักศึกษามีอาจารย์ที่ปรึกษา 1 คน)
📌 Teacher มี Students (List<Student>) → Association (อาจารย์ที่ปรึกษามีนักศึกษาได้หลายคน)

🔹 รูปแบบข้อมูลที่เป็นระบบ 🔹

นักศึกษามีรหัส, เกรดเฉลี่ย, สาขาวิชา และอาจารย์ที่ปรึกษา
อาจารย์มีวิชาที่สอน และสามารถดูแลนักศึกษาได้หลายคน
ระบบรองรับ Enum เพื่อกำหนดค่าที่แน่นอน เช่น Major และ อาจารย์ที่ปรึกษา



ไดอะแกรมแสดงความสัมพันธ์ระหว่างคลาสต่างๆ ดังนี้:

Student และ Teacher สืบทอดจาก DataMajor (Inheritance)
Student มีความสัมพันธ์กับ Teacher แบบ association (Student มี Advisor เป็น Teacher)
Teacher มีความสัมพันธ์กับ Student แบบ association (Teacher มี Students เป็น List ของ Student)
