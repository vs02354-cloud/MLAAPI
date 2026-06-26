INSERT INTO "Msr_LocalBody" ("LocalBodyId", "DistrictId", "LocalBodyType", "LocalBodyName", "LocalBodyNameHindi") VALUES (999, 999, 'Gram Panchayat', 'Test LB', 'Test LB') ON CONFLICT DO NOTHING;
INSERT INTO "Msr_Village" ("VillageId", "LocalBodyId", "VillageName", "VillageNameHindi") VALUES (999, 999, 'Test Vill', 'Test Vill') ON CONFLICT DO NOTHING;
