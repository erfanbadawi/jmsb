-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`BILLING`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`BILLING` ;

CREATE TABLE IF NOT EXISTS `mydb`.`BILLING` (
  `Billing_ID` INT NOT NULL,
  `Billing_Name` VARCHAR(45) NULL,
  `Billing_Address` VARCHAR(200) NULL,
  `Billing_BankName` VARCHAR(45) NULL,
  `Billing_CardNumber` BIGINT(20) NULL,
  `Billing_ExpirationDate` DATE NULL,
  `Billing_SecurityCode` INT NULL,
  PRIMARY KEY (`Billing_ID`),
  UNIQUE INDEX `Billing_ID_UNIQUE` (`Billing_ID` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`CUSTOMER`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`CUSTOMER` ;

CREATE TABLE IF NOT EXISTS `mydb`.`CUSTOMER` (
  `Customer_ID` INT NOT NULL,
  `Billing_ID` INT NULL,
  `Customer_Fname` VARCHAR(45) NULL,
  `Customer_Lname` VARCHAR(45) NULL,
  `Customer_BirthDate` DATE NULL,
  `Customer_Address` VARCHAR(100) NULL,
  `Customer_PhoneNumber` VARCHAR(40) NULL,
  `Customer_Email` VARCHAR(100) NULL,
  `Customer_Type` VARCHAR(70) NULL,
  PRIMARY KEY (`Customer_ID`),
  INDEX `Billing_idx` (`Billing_ID` ASC),
  CONSTRAINT `Billing`
    FOREIGN KEY (`Billing_ID`)
    REFERENCES `mydb`.`BILLING` (`Billing_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`FREE`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`FREE` ;

CREATE TABLE IF NOT EXISTS `mydb`.`FREE` (
  `Customer_ID` INT NOT NULL,
  `Free_RegistrationDate` DATE NULL,
  PRIMARY KEY (`Customer_ID`),
  CONSTRAINT `mer_ID`
    FOREIGN KEY (`Customer_ID`)
    REFERENCES `mydb`.`CUSTOMER` (`Customer_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`ORDER`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`ORDER` ;

CREATE TABLE IF NOT EXISTS `mydb`.`ORDER` (
  `Order_ID` INT NOT NULL,
  `Customer_ID` INT NOT NULL,
  `Order_Status` VARCHAR(45) NULL,
  `Order_Date` DATE NULL,
  PRIMARY KEY (`Order_ID`),
  INDEX `Customer_ID_idx` (`Customer_ID` ASC),
  CONSTRAINT `Custo_ID`
    FOREIGN KEY (`Customer_ID`)
    REFERENCES `mydb`.`CUSTOMER` (`Customer_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`SELLER`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`SELLER` ;

CREATE TABLE IF NOT EXISTS `mydb`.`SELLER` (
  `Seller_ID` INT NOT NULL,
  `Seller_BusinessName` VARCHAR(75) NULL,
  `Seller_Email` VARCHAR(75) NOT NULL,
  `Seller_Address` VARCHAR(100) NULL,
  `Seller_PhoneNumber` VARCHAR(40) NULL,
  PRIMARY KEY (`Seller_ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`SHIPMENT`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`SHIPMENT` ;

CREATE TABLE IF NOT EXISTS `mydb`.`SHIPMENT` (
  `Shipment_ID` INT NOT NULL,
  `Order_ID` INT NOT NULL,
  `Seller_ID` INT NULL,
  `Shipment_Address` VARCHAR(100) NULL,
  `Shipment_ShippingDate` DATE NULL,
  `Shipment_ExpectedDeliveryDate` DATE NULL,
  `Shipment_Fee` DECIMAL(4,2) NULL,
  PRIMARY KEY (`Shipment_ID`),
  INDEX `Order_ID_idx` (`Order_ID` ASC),
  INDEX `Seller_ID_idx` (`Seller_ID` ASC),
  CONSTRAINT `Orer_ID`
    FOREIGN KEY (`Order_ID`)
    REFERENCES `mydb`.`ORDER` (`Order_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Sellll_ID`
    FOREIGN KEY (`Seller_ID`)
    REFERENCES `mydb`.`SELLER` (`Seller_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`CATEGORY`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`CATEGORY` ;

CREATE TABLE IF NOT EXISTS `mydb`.`CATEGORY` (
  `Category_ID` INT NOT NULL,
  `Category_Name` VARCHAR(45) NULL,
  `Category_Description` VARCHAR(250) NULL,
  PRIMARY KEY (`Category_ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`PRODUCT`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`PRODUCT` ;

CREATE TABLE IF NOT EXISTS `mydb`.`PRODUCT` (
  `Product_ID` INT NOT NULL,
  `Category_ID` INT NOT NULL,
  `Product_Name` VARCHAR(45) NOT NULL,
  `Product_Type` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Product_ID`),
  INDEX `Category_ID_idx` (`Category_ID` ASC),
  CONSTRAINT `Category_ID`
    FOREIGN KEY (`Category_ID`)
    REFERENCES `mydb`.`CATEGORY` (`Category_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`WISHLIST`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`WISHLIST` ;

CREATE TABLE IF NOT EXISTS `mydb`.`WISHLIST` (
  `Wishlist_ID` INT NOT NULL,
  `Customer_ID` INT NOT NULL,
  `Wishlist_Name` VARCHAR(45) NULL,
  `Wishlist_Description` VARCHAR(750) NULL,
  PRIMARY KEY (`Wishlist_ID`),
  INDEX `Customer_idx` (`Customer_ID` ASC),
  CONSTRAINT `Customer`
    FOREIGN KEY (`Customer_ID`)
    REFERENCES `mydb`.`CUSTOMER` (`Customer_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`WISHLIST_PRODUCT`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`WISHLIST_PRODUCT` ;

CREATE TABLE IF NOT EXISTS `mydb`.`WISHLIST_PRODUCT` (
  `Wishlist_ID` INT NOT NULL,
  `Product_ID` INT NOT NULL,
  PRIMARY KEY (`Product_ID`, `Wishlist_ID`),
  INDEX `Wishlist_ID_idx` (`Wishlist_ID` ASC),
  CONSTRAINT `Prot_ID`
    FOREIGN KEY (`Product_ID`)
    REFERENCES `mydb`.`PRODUCT` (`Product_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Wshlst_ID`
    FOREIGN KEY (`Wishlist_ID`)
    REFERENCES `mydb`.`WISHLIST` (`Wishlist_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`REVIEW`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`REVIEW` ;

CREATE TABLE IF NOT EXISTS `mydb`.`REVIEW` (
  `Review_ID` INT NOT NULL,
  `Product_ID` INT NOT NULL,
  `Customer_ID` INT NOT NULL,
  `Review_Rating` INT NOT NULL,
  `Review_Text` VARCHAR(750) NULL,
  PRIMARY KEY (`Review_ID`),
  INDEX `Customer_ID_idx` (`Customer_ID` ASC),
  INDEX `Product_ID_idx` (`Product_ID` ASC),
  CONSTRAINT `oduct_ID`
    FOREIGN KEY (`Product_ID`)
    REFERENCES `mydb`.`PRODUCT` (`Product_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `tomer_ID`
    FOREIGN KEY (`Customer_ID`)
    REFERENCES `mydb`.`CUSTOMER` (`Customer_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`PHYSICAL`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`PHYSICAL` ;

CREATE TABLE IF NOT EXISTS `mydb`.`PHYSICAL` (
  `Product_ID` INT NOT NULL,
  `Physical_Weight_lbs` INT NOT NULL,
  `Physical_QuantityAvailable` INT NULL,
  PRIMARY KEY (`Product_ID`),
  CONSTRAINT `Puct_ID`
    FOREIGN KEY (`Product_ID`)
    REFERENCES `mydb`.`PRODUCT` (`Product_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`DIGITAL`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`DIGITAL` ;

CREATE TABLE IF NOT EXISTS `mydb`.`DIGITAL` (
  `Product_ID` INT NOT NULL,
  `Digital_Instructions` VARCHAR(250) NOT NULL,
  `Digital_Size_kilobytes` INT NULL,
  PRIMARY KEY (`Product_ID`),
  CONSTRAINT `oct_ID`
    FOREIGN KEY (`Product_ID`)
    REFERENCES `mydb`.`PRODUCT` (`Product_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`ORDER_PER_PRODUCT`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`ORDER_PER_PRODUCT` ;

CREATE TABLE IF NOT EXISTS `mydb`.`ORDER_PER_PRODUCT` (
  `Order_ID` INT NOT NULL,
  `Product_ID` INT NOT NULL,
  `Seller_ID` INT NOT NULL,
  `Order_Per_Prod_Price` DECIMAL(5,2) NULL,
  `Order_Per_Prod_Quantity` INT NULL,
  PRIMARY KEY (`Order_ID`, `Product_ID`, `Seller_ID`),
  INDEX `Product_ID_idx` (`Product_ID` ASC),
  INDEX `Slrr_idx` (`Seller_ID` ASC),
  CONSTRAINT `Orffllde_ID`
    FOREIGN KEY (`Order_ID`)
    REFERENCES `mydb`.`ORDER` (`Order_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Porodollf_ID`
    FOREIGN KEY (`Product_ID`)
    REFERENCES `mydb`.`PRODUCT` (`Product_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Slrr_D`
    FOREIGN KEY (`Seller_ID`)
    REFERENCES `mydb`.`SELLER` (`Seller_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`PREMIUM`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`PREMIUM` ;

CREATE TABLE IF NOT EXISTS `mydb`.`PREMIUM` (
  `Customer_ID` INT NOT NULL,
  `Premium_StartDate` DATE NULL,
  `Premium_EndDate` DATETIME NULL,
  `Premium_Fee` DECIMAL(6,2) NULL,
  PRIMARY KEY (`Customer_ID`),
  CONSTRAINT `omer_ID`
    FOREIGN KEY (`Customer_ID`)
    REFERENCES `mydb`.`CUSTOMER` (`Customer_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`RATING`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`RATING` ;

CREATE TABLE IF NOT EXISTS `mydb`.`RATING` (
  `Rating_ID` INT NOT NULL,
  `Seller_ID` INT NULL,
  `Customer_ID` INT NULL,
  `Rating_Stars` INT NULL,
  PRIMARY KEY (`Rating_ID`),
  INDEX `Customer_ID_idx` (`Customer_ID` ASC),
  INDEX `Seller_ID_idx` (`Seller_ID` ASC),
  CONSTRAINT `Cer_ID`
    FOREIGN KEY (`Customer_ID`)
    REFERENCES `mydb`.`CUSTOMER` (`Customer_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Ser_ID`
    FOREIGN KEY (`Seller_ID`)
    REFERENCES `mydb`.`SELLER` (`Seller_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;
