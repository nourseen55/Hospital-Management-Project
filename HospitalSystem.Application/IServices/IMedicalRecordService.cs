﻿namespace HospitalSystem.Application.Services
{
    public interface IMedicalRecordService
    {
        Task AddMedicalRecordAsync(MedicalRecord MedicalRecord);
        Task<MedicalRecord> GetMedicalRecordByIdAsync(int id);
        Task<IEnumerable<MedicalRecord>> GetAllMedicalRecordsAsync();
        Task UpdateMedicalRecordAsync(MedicalRecord MedicalRecord);
        Task DeleteMedicalRecordAsync(int id);
    }
}