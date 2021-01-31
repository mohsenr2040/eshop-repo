﻿using eshop.Application.Interfaces.Contexts;
using eshop.Common.Dto;
using eshop.Domain.Entities.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.Application.Services.Payments.Commands.AddPayment
{
    public interface IAddPaymentService
    {
        ResultDto<ResultPaymentDto> Execute(int Amount, string UserId);
    }
    public class AddPaymentService : IAddPaymentService
    {
        private readonly IDataBaseContext _context;
        public AddPaymentService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<ResultPaymentDto> Execute(int Amount, string UserId)
        {
            var user = _context.Users.Find(UserId);
            Payment Payment1 = new Payment()
            {
                Guid=Guid.NewGuid(),
                Amount=Amount,
                User=user,
                IsPayed=false,
            };
            _context.Payments.Add(Payment1);
            _context.SaveChanges();
            return new ResultDto<ResultPaymentDto>()
            {
                Data = new ResultPaymentDto
                {
                    Guid = Payment1.Guid,
                    Amount= Payment1.Amount,
                    Email=user.Email,
                    PaymentId= Payment1.Id,
                },
                IsSuccess = true,
            };

        }
    }
    public class ResultPaymentDto
    {
        public Guid Guid { get; set; }
        public int Amount { get; set; }
        public string Email { get; set; }
        public int PaymentId { get; set; }
    }
}
