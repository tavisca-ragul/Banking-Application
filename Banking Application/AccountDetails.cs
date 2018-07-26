using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Application {
    class AccountDetails
    {
        private String accountType, CIFNo, accountNo, IFSCCode, customerName, address, DOB, phone, EMailID, MICR;
        private double balance;

        public AccountDetails()
        {
            this.accountType = "";
            this.CIFNo = "";
            this.accountNo = "";
            this.IFSCCode = "";
            this.customerName = "";
            this.address = "";
            this.DOB = "";
            this.phone = "";
            this.EMailID = "";
            this.MICR = "";
            this.balance = 0;
        }

        public AccountDetails(String accountType, String cIFNo, String accountNo, String iFSCCode, String customerName,
            String address, String dOB, String phone, String eMailID, String mICR, double balance)
        {
            this.accountType = accountType;
            this.CIFNo = cIFNo;
            this.accountNo = accountNo;
            this.IFSCCode = iFSCCode;
            this.customerName = customerName;
            this.address = address;
            this.DOB = dOB;
            this.phone = phone;
            this.EMailID = eMailID;
            this.MICR = mICR;
            this.balance = balance;
        }

        public String getAccountType()
        {
            return accountType;
        }

        public void setAccountType(String accountType)
        {
            this.accountType = accountType;
        }

        public String getCIFNo()
        {
            return CIFNo;
        }

        public void setCIFNo(String cIFNo)
        {
            this.CIFNo = cIFNo;
        }

        public String getAccountNo()
        {
            return accountNo;
        }

        public void setAccountNo(String accountNo)
        {
            this.accountNo = accountNo;
        }

        public String getIFSCCode()
        {
            return IFSCCode;
        }

        public void setIFSCCode(String iFSCCode)
        {
            this.IFSCCode = iFSCCode;
        }

        public String getCustomerName()
        {
            return customerName;
        }

        public void setCustomerName(String customerName)
        {
            this.customerName = customerName;
        }

        public String getAddress()
        {
            return address;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }

        public String getDOB()
        {
            return DOB;
        }

        public void setDOB(String dOB)
        {
            this.DOB = dOB;
        }

        public String getPhone()
        {
            return phone;
        }

        public void setPhone(String phone)
        {
            this.phone = phone;
        }

        public String getEMailID()
        {
            return EMailID;
        }

        public void setEMailID(String eMailID)
        {
            this.EMailID = eMailID;
        }

        public String getMICR()
        {
            return MICR;
        }

        public void setMICR(String mICR)
        {
            this.MICR = mICR;
        }

        public Double getBalance()
        {
            return balance;
        }

        public void setBalance(Double balance)
        {
            this.balance = balance;
        }
    }
}
