# Inventory Management System

## Project Overview
Develop a C# console application to inventory management system implemented in C# that provides essential functionality for tracking and managing product stock.

## Requirements

#### 1. Product Management
- **Adding Products**
  - Validate product name is not empty
  - Ensure price is a valid positive decimal
  - Verify initial quantity is non-negative
  - Auto-generate unique product IDs

- **Removing Products**
  - Validate product exists before removal
  - Check remaining stock before deletion
  - Handle removal confirmation

#### 2. Inventory Operations
- **Stock Updates**
  - Support both stock increase and decrease
  - Prevent negative stock levels
  - Validate quantity changes
  - Provide clear error messages for invalid operations

- **Inventory Display**
  - Show all product details in formatted output
  - Display prices in currency format
  - Handle empty inventory scenarios

#### 3. Input Validation
- Numeric input validation for:
  - Product ID
  - Price
  - Quantity
- String validation for product names
- Error handling with descriptive messages
 
## Objectives

#### 1.Implemente inventory operations: add, update, view, and remove products.
#### 2.Implemente stock tracking with input validation.
#### 3.Implemente a simple, user-friendly console interface.
#### 4.Write maintainable, well-structured C# code.
