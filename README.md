# 🎱 Pool Table Timer & Billing System

A **C# .NET WinForms** project to manage pool table sessions with real-time tracking, automatic billing, and event-driven architecture.  
Designed as a reusable **UserControl (`ctrPoolTable`)** for easy integration into multi-table management systems.

---

## 📌 Features
- **Start/Stop Timer** – Track game duration in real-time.
- **End Session & Billing** – Automatically calculate total fees based on hourly rates.
- **Custom UserControl** – Modular and reusable for any number of tables.
- **Event-Driven Updates** – Uses `EventHandler<CompletedEventArgs>` to notify when a session ends.
- **Customizable Properties** – Table name, player name, and hourly rate can be set at runtime.
- **Visual Feedback** – Table status changes with active/inactive images.

---

## 🛠️ Tech Stack
- **Language:** C#  
- **Framework:** .NET WinForms  
- **Concepts:** Event Handlers, Delegates, Custom Properties, OOP

---

## 📂 Project Structure
