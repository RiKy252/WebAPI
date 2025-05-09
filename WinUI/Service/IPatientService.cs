﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WinUI.Model;

namespace WinUI.Service
{
    public interface IPatientService
    {
        PatientJointModel _patient_info { get; }
        List<PatientJointModel> _patient_list { get; }

        Task<bool> loadPatientInfoByUserId(int _user_id);
        Task<bool> loadAllPatients();

        Task<bool> updateWeight(int _user_id, double weight);
        Task<bool> updateHeight(int _user_id, int _height);
        Task<bool> updateEmergencyContact(int _user_id, string _emergency_contact);

        Task<bool> logUpdate(int _user_id, ActionType _action);
    }
}
