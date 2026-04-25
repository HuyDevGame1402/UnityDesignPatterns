# 🏗️ Unity Design Patterns Collection

Dự án này là một bộ sưu tập các **Design Patterns (Mẫu thiết kế)** phổ biến được áp dụng trong môi trường **Unity Engine**. Mục tiêu của dự án là xây dựng hệ thống code linh hoạt, dễ mở rộng và bảo trì cho các dự án game phức tạp.

## 🚀 Các Design Patterns đã triển khai

Dự án bao gồm các nhóm mẫu thiết kế chính:

### 1. Creational Patterns (Nhóm khởi tạo)
* **Singleton:** Đảm bảo một lớp chỉ có một thực thể duy nhất (thường dùng cho GameManagers).
* **Factory Method & Abstract Factory:** Khởi tạo các đối tượng mà không cần chỉ định chính xác lớp cụ thể.
* **Builder & Builder All:** Tách biệt quá trình xây dựng một đối tượng phức tạp khỏi phần đại diện của nó.
* **Prototype:** Tạo các đối tượng mới bằng cách sao chép một đối tượng mẫu có sẵn.

### 2. Behavioral Patterns (Nhóm hành vi)
* **Observer Pattern:** Cơ chế đăng ký và thông báo sự kiện giữa các đối tượng (Decoupling).
* **Command Pattern:** Đóng gói các yêu cầu thành các đối tượng, hỗ trợ tính năng Undo/Redo.
* **State Pattern:** Cho phép đối tượng thay đổi hành vi khi trạng thái nội bộ của nó thay đổi (FSM).
* **Strategy Pattern:** Định nghĩa một tập hợp các thuật toán và cho phép thay đổi chúng linh hoạt khi runtime.

### 3. Structural Patterns (Nhóm cấu trúc)
* **Decorator Pattern:** Thêm các trách nhiệm mới cho đối tượng một cách năng động mà không ảnh hưởng đến các đối tượng khác.

## 📁 Cấu trúc thư mục (Folder Structure)

```text
├── Assets/
│   ├── Scenes/            # Các cảnh demo cho từng loại Pattern
│   └── Scripts 1/         # Mã nguồn chính chia theo từng Pattern
│       ├── ABSTRACT FACTORY
│       ├── BUILDER
│       ├── COMMAND PATTERN
│       ├── DECORATOR PATTERN
│       ├── FACTORY METHOD
│       ├── OBSERVER PATTERN BASE
│       ├── PROTOTYPE
│       ├── SINGLETON
│       ├── STATE PATTERN
│       └── STRATEGY PATTERN
└── project.godot (hoặc cấu hình Unity tương ứng)
