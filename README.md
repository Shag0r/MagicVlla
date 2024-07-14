#Magic Villa UI
![image](https://github.com/user-attachments/assets/faf94d82-fc46-4b0c-90c3-df74f3cadf20)
#Villa List Display
![image](https://github.com/user-attachments/assets/88f99b68-bec8-4888-9c30-29bfd9384aec)
#Create Villa 
![image](https://github.com/user-attachments/assets/43f5d2ff-118f-4560-9cc7-519fc5aa9556)

#Edit Villa
![image](https://github.com/user-attachments/assets/b7fe10fd-69d3-4db5-96aa-319d07a9a8d1)

#Delete Villa
![image](https://github.com/user-attachments/assets/dd506b69-cfba-46e8-ab28-8061cbc0e8ef)

#villa Number List Display
![image](https://github.com/user-attachments/assets/19cf4ddf-ae1e-4124-bc33-f1fc9780d162)



#Magic Villa Api
![image](https://github.com/Shag0r/MagicVlla/assets/101504353/a1177c64-ebde-432d-9113-f4e2f0574daa)

# Magic Villa API

Welcome to the Magic Villa API project! This repository contains the source code for a robust API designed to manage villa-related operations efficiently. Built with ASP.NET Core, the API leverages Entity Framework Core for data access, AutoMapper for object mapping, and follows best practices for RESTful API design.

## Overview

Magic Villa API provides a comprehensive solution for managing villas and villa numbers. It includes CRUD operations (Create, Read, Update, Delete) and utilizes DTOs (Data Transfer Objects) to ensure that data is handled securely and efficiently between the client and server.

### Key Features

- **CRUD Operations**: The API supports full CRUD operations for both villas and villa numbers.
- **Error Handling**: Robust error handling ensures that the API provides meaningful responses and logs errors for further analysis.
- **AutoMapper Integration**: Simplifies the mapping between entity models and DTOs.
- **Async/Await**: Asynchronous programming is used to enhance performance and scalability.
- **Patch Support**: Allows partial updates to resources using HTTP PATCH.

## Project Structure

The project is organized into several key components:

### Controllers

1. **VillaAPIController**: Manages operations related to villas.
    - `GetVillas()`: Retrieves all villas.
    - `GetVillaById(int id)`: Retrieves a specific villa by ID.
    - `CreateVilla(VillaCreateDTO villaDto)`: Creates a new villa.
    - `DeleteVilla(int id)`: Deletes a villa by ID.
    - `UpdateWithPut(int id, VillaUpdateDTO villaDto)`: Updates a villa entirely.
    - `UpdateWithPatch(int id, JsonPatchDocument<VillaUpdateDTO> patchDto)`: Partially updates a villa.

2. **VillaNumberAPIController**: Manages operations related to villa numbers.
    - `GetVillaNumbers()`: Retrieves all villa numbers.
    - `GetVillaNumberById(int id)`: Retrieves a specific villa number by ID.
    - `CreateVillaNumber(VillaNumberDTO villaDto)`: Creates a new villa number.
    - `DeleteVillaNumber(int id)`: Deletes a villa number by ID.
    - `UpdateResponse(int id, VillaNumberDTO villaDto)`: Updates a villa number entirely.

### Models

- **Villa**: Represents the villa entity with properties such as `Id`, `Name`, `Description`, `Rate`, `sqft`, `Occupancy`, `ImageUrl`, `Amenity`, `CreatedDate`, and `UpdatedDate`.
- **VillaNumber**: Represents the villa number entity with properties such as `villaNo`, `villaID`, `Villa`, `SpecialDetails`, `CreatedDate`, and `UpdatedDate`.

### DTOs

- **VillaDTO**: Data transfer object for the `Villa` model.
- **VillaCreateDTO**: Used when creating a new villa.
- **VillaUpdateDTO**: Used when updating an existing villa.
- **VillaNumberDTO**: Data transfer object for the `VillaNumber` model.
- **VillaNumberCreateDTO**: Used when creating a new villa number.
- **VillaNumberUpdateDTO**: Used when updating an existing villa number.

### Mapping Configuration

The mapping between entity models and DTOs is configured using AutoMapper in the `MappingConfig` class.

### Repository Interfaces

- **IVillaRepository**: Defines the contract for villa-related data operations.
- **IVillaNumberRepository**: Defines the contract for villa number-related data operations.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [AutoMapper](https://automapper.org/)

### Running the Application

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/magic-villa-api.git
   ```

2. Navigate to the project directory:

   ```bash
   cd magic-villa-api
   ```

3. Restore the dependencies:

   ```bash
   dotnet restore
   ```

4. Update the database:

   ```bash
   dotnet ef database update
   ```

5. Run the application:

   ```bash
   dotnet run
   ```

### API Endpoints

- **GET /api/VillaAPI**: Retrieve all villas.
- **GET /api/VillaAPI/{id}**: Retrieve a specific villa by ID.
- **POST /api/VillaAPI**: Create a new villa.
- **DELETE /api/VillaAPI/{id}**: Delete a villa by ID.
- **PUT /api/VillaAPI/{id}**: Update a villa entirely.
- **PATCH /api/VillaAPI/{id}**: Partially update a villa.
- **GET /api/VillaNumberAPI**: Retrieve all villa numbers.
- **GET /api/VillaNumberAPI/{id}**: Retrieve a specific villa number by ID.
- **POST /api/VillaNumberAPI**: Create a new villa number.
- **DELETE /api/VillaNumberAPI/{id}**: Delete a villa number by ID.
- **PUT /api/VillaNumberAPI/{id}**: Update a villa number entirely.

## Contributing

Contributions are welcome! Please fork this repository and submit pull requests.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any questions or feedback, please open an issue or contact me at shagorkumardas@gmail.com.

---

Thank you for exploring the Magic Villa API! Your contributions and feedback are greatly appreciated.
