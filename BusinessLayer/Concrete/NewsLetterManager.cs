﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager:INewsLetterService
    {
        INewsletterDal _newsLetterDal;
        public NewsLetterManager(INewsletterDal newsletterDal)
        {
            _newsLetterDal = newsletterDal;
        }
        public void AddNewsLetter(NewsLetter newsLetter)
        {
            _newsLetterDal.Insert(newsLetter);
        }
    }
}
