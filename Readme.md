# Inventory Management System

## Project Overview
This is a simple C# console application implemented for managing product inventory. The system allows users to:
- Track products with their names, prices, and quantities
- Perform basic inventory operations (add, remove, update, view)
- Maintain accurate stock levels with validation
- Handle product data through a simple command-line interface

The application is built with a focus on reliability and ease of use.

## Requirements

### Functional Requirements

#### 1. Product Operations
- **Product Creation**
  - Add products with unique auto-incrementing ID
  - Store product name, price, and quantity
  - Initialize stock levels for new products

- **Stock Management**
  - Update product quantities (increase/decrease)
  - Remove products from inventory
  - Block removal of products with remaining stock
  - Prevent negative stock quantities

- **Inventory Queries**
  - List all products in inventory
  - View individual product details
  - Display empty inventory notifications
  - Show prices in currency format ($XX.XX)

#### 2. Data Validation
- **Input Validation**
  - Verify product ID exists
  - Validate numeric inputs (price, quantity)
  - Check for empty/null product names
  - Validate stock adjustment amounts

### Non-Functional Requirements

#### 1. User Interface
- Console-based menu system
- Clear operation options (Add/Update/View/Remove)
- Consistent user prompts
- Clear error messaging
- Operation confirmation messages

#### 2. Data Management
- In-memory product storage using List<Product>
- Data consistency during operations

#### 3. Error Handling
- Descriptive error messages
- Input validation feedback

#### 4. Code Structure
- Object-oriented design (Product, Inventory classes)
- Clean method organization
- Separation of concerns
- Clear method responsibilities

## Objectives

- 1.Implemente inventory operations: add, update, view, and remove products.
- 2.Implemente stock tracking with input validation.
- 3.Implemente a simple, user-friendly console interface.
- 4.Write maintainable, well-structured C# code.
