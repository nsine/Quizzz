﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizzzClient.Web.Models.ApiViewModels
{
    public class QuizzPreviewViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int CountOfQuestions { get; set; }
        public int AttemptsCount { get; set; }
        public int PassesCount { get; set; }
    }
}
