# Gym Management System (GMS1) 🏋️‍♂️

A comprehensive gym management database system developed using **C#** and **Microsoft SQL Server**. This project focuses on efficient data handling for fitness centers, covering everything from member registration to financial reporting.

## 🚀 Key Features

*   **Inventory Management:** Track and manage gym equipment status (Add/Edit/Delete/Monitor).
*   **QR Code Member System:** Integrated member identification using QR codes for quick check-ins.
*   **Tiered Subscription Packages:** Supports flexible membership plans including **Daily, Monthly, and Yearly** tiers.
*   **Advanced Reporting:** 
    *   Generates membership registration reports (Daily to Yearly views).
    *   Summarizes gym **Income and Expenses** for financial tracking.
*   **Relational Database Design:** Optimized Schema for handling complex relationships between members, payments, and equipment.

## 🛠 Tech Stack

*   **Language:** C# (.NET Framework / .NET Core)
*   **Database:** Microsoft SQL Server (T-SQL)
*   **Tools:** Visual Studio, SQL Server Management Studio (SSMS)
*   **Key Concepts:** CRUD Operations, Relational Database Design, Data Reporting.

## 📊 Database Architecture
The system architecture focuses on data integrity across several core tables:
*   **Members:** Stores personal profiles and QR-linked IDs.
*   **Packages:** Manages pricing logic and duration for different subscription tiers.
*   **Equipment:** Tracks inventory and maintenance schedules.
*   **Transactions:** Logs all financial data for revenue/expense reporting.
