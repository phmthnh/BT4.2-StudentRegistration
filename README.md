# BT4.2 – Form Đăng Ký Học Viên

> **Môn:** Lập trình Windows Forms với C# | **Framework:** .NET 10.0

## Mục tiêu
Sử dụng đa dạng Input Controls: **ComboBox** (Binding Data), **CheckBox**, **DateTimePicker** & **MaskedTextBox**.

## Tính năng

| Control | Chức năng |
|---------|-----------|
| `txtFullName` | Nhập họ và tên |
| `dtpBirthDate` | Chọn ngày sinh — Format Short `dd/MM/yyyy` |
| `mtxtPhone` | Nhập SĐT theo Mask `(000) 000-0000` |
| `cboCourse` | Danh sách khóa học — `DisplayMember` / `ValueMember` |
| `chkEnglish` / `chkSoftSkills` / `chkIT` | Môn học bổ sung |
| `btnRegister` | Tổng hợp & in thông tin đăng ký lên `MessageBox` |
| `btnClear` | Xóa toàn bộ form |

## Demo

### Giao diện form & thông tin đăng ký
![Form đăng ký - Thông tin](Screenshot%202026-09-23%20164224.png)

### Danh sách khóa học (ComboBox)
![Form đăng ký - ComboBox khóa học](Screenshot%202026-09-23%20164341.png)

## Cách chạy

```bash
dotnet run
```

hoặc mở file `BT4_2_StudentRegistration.sln` bằng **Visual Studio 2022+** và nhấn `F5`.

## Yêu cầu hệ thống
- .NET 10.0 SDK
- Windows OS (Windows Forms)
- Visual Studio 2022 (khuyến nghị)
