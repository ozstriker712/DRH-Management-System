
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/15/2014 10:35:02
-- Generated from EDMX file: C:\Users\Ozstriker\Desktop\00000000\apc\apc\Modele\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [db1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_employdoc_vacance]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doc_vacanceSet] DROP CONSTRAINT [FK_employdoc_vacance];
GO
IF OBJECT_ID(N'[dbo].[FK_employdoc_promotion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doc_promotionSet] DROP CONSTRAINT [FK_employdoc_promotion];
GO
IF OBJECT_ID(N'[dbo].[FK_employdoc_ta9yim]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doc_ta9yimSet] DROP CONSTRAINT [FK_employdoc_ta9yim];
GO
IF OBJECT_ID(N'[dbo].[FK_employdoc_displine]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doc_displineSet] DROP CONSTRAINT [FK_employdoc_displine];
GO
IF OBJECT_ID(N'[dbo].[FK_employdoc_7araka]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doc_7arakaSet] DROP CONSTRAINT [FK_employdoc_7araka];
GO
IF OBJECT_ID(N'[dbo].[FK_employdoc_vacane_plus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doc_vacane_plusSet] DROP CONSTRAINT [FK_employdoc_vacane_plus];
GO
IF OBJECT_ID(N'[dbo].[FK_employdoc_morasalt_idariya]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doc_morasalt_idariyaSet] DROP CONSTRAINT [FK_employdoc_morasalt_idariya];
GO
IF OBJECT_ID(N'[dbo].[FK_employdoc_mo7asaba]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doc_mo7asabaSet] DROP CONSTRAINT [FK_employdoc_mo7asaba];
GO
IF OBJECT_ID(N'[dbo].[FK_rotbaemploy]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[employSet] DROP CONSTRAINT [FK_rotbaemploy];
GO
IF OBJECT_ID(N'[dbo].[FK_brancheemploy]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[employSet] DROP CONSTRAINT [FK_brancheemploy];
GO
IF OBJECT_ID(N'[dbo].[FK_brancherotba]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[rotbaSet] DROP CONSTRAINT [FK_brancherotba];
GO
IF OBJECT_ID(N'[dbo].[FK_employdoc2_chngmnt_poste]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doc2_chngmnt_posteSet] DROP CONSTRAINT [FK_employdoc2_chngmnt_poste];
GO
IF OBJECT_ID(N'[dbo].[FK_employdoc2_chngmt_daraja]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doc2_chngmt_darajaSet] DROP CONSTRAINT [FK_employdoc2_chngmt_daraja];
GO
IF OBJECT_ID(N'[dbo].[FK_employdoc2_chngmnt_delgation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doc2_chngmnt_delgationSet] DROP CONSTRAINT [FK_employdoc2_chngmnt_delgation];
GO
IF OBJECT_ID(N'[dbo].[FK_employdoc2_charge_poste]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doc2_charge_poste] DROP CONSTRAINT [FK_employdoc2_charge_poste];
GO
IF OBJECT_ID(N'[dbo].[FK_apc_annex_catgrapc_annex_catgr_detail]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[apc_annex_catgr_detail] DROP CONSTRAINT [FK_apc_annex_catgrapc_annex_catgr_detail];
GO
IF OBJECT_ID(N'[dbo].[FK_apc_annex_catgremploy]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[employSet] DROP CONSTRAINT [FK_apc_annex_catgremploy];
GO
IF OBJECT_ID(N'[dbo].[FK_apc_annex_catgr_detailemploy]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[employSet] DROP CONSTRAINT [FK_apc_annex_catgr_detailemploy];
GO
IF OBJECT_ID(N'[dbo].[FK_apc_annex_catgrdoc2_charge_poste]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doc2_charge_poste] DROP CONSTRAINT [FK_apc_annex_catgrdoc2_charge_poste];
GO
IF OBJECT_ID(N'[dbo].[FK_apc_annex_catgr_detaildoc2_charge_poste]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doc2_charge_poste] DROP CONSTRAINT [FK_apc_annex_catgr_detaildoc2_charge_poste];
GO
IF OBJECT_ID(N'[dbo].[FK_rotbadoc_promotion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doc_promotionSet] DROP CONSTRAINT [FK_rotbadoc_promotion];
GO
IF OBJECT_ID(N'[dbo].[FK_loginemploy]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[employSet] DROP CONSTRAINT [FK_loginemploy];
GO
IF OBJECT_ID(N'[dbo].[FK_employlieu_nominaiton]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[lieu_nominaiton] DROP CONSTRAINT [FK_employlieu_nominaiton];
GO
IF OBJECT_ID(N'[dbo].[FK_apc_annex_catgrlieu_nominaiton]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[lieu_nominaiton] DROP CONSTRAINT [FK_apc_annex_catgrlieu_nominaiton];
GO
IF OBJECT_ID(N'[dbo].[FK_apc_annex_catgr_detaillieu_nominaiton]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[lieu_nominaiton] DROP CONSTRAINT [FK_apc_annex_catgr_detaillieu_nominaiton];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[employSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[employSet];
GO
IF OBJECT_ID(N'[dbo].[doc_vacanceSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[doc_vacanceSet];
GO
IF OBJECT_ID(N'[dbo].[rotbaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[rotbaSet];
GO
IF OBJECT_ID(N'[dbo].[doc_promotionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[doc_promotionSet];
GO
IF OBJECT_ID(N'[dbo].[doc_ta9yimSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[doc_ta9yimSet];
GO
IF OBJECT_ID(N'[dbo].[doc_mo7asabaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[doc_mo7asabaSet];
GO
IF OBJECT_ID(N'[dbo].[doc_7arakaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[doc_7arakaSet];
GO
IF OBJECT_ID(N'[dbo].[doc_displineSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[doc_displineSet];
GO
IF OBJECT_ID(N'[dbo].[doc_vacane_plusSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[doc_vacane_plusSet];
GO
IF OBJECT_ID(N'[dbo].[doc_morasalt_idariyaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[doc_morasalt_idariyaSet];
GO
IF OBJECT_ID(N'[dbo].[brancheSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[brancheSet];
GO
IF OBJECT_ID(N'[dbo].[doc2_chngmt_darajaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[doc2_chngmt_darajaSet];
GO
IF OBJECT_ID(N'[dbo].[doc2_chngmnt_delgationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[doc2_chngmnt_delgationSet];
GO
IF OBJECT_ID(N'[dbo].[doc2_chngmnt_posteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[doc2_chngmnt_posteSet];
GO
IF OBJECT_ID(N'[dbo].[doc2_charge_poste]', 'U') IS NOT NULL
    DROP TABLE [dbo].[doc2_charge_poste];
GO
IF OBJECT_ID(N'[dbo].[apc_annex_catgr]', 'U') IS NOT NULL
    DROP TABLE [dbo].[apc_annex_catgr];
GO
IF OBJECT_ID(N'[dbo].[apc_annex_catgr_detail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[apc_annex_catgr_detail];
GO
IF OBJECT_ID(N'[dbo].[logins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[logins];
GO
IF OBJECT_ID(N'[dbo].[lieu_nominaiton]', 'U') IS NOT NULL
    DROP TABLE [dbo].[lieu_nominaiton];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'employSet'
CREATE TABLE [dbo].[employSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nom_ar] nvarchar(max)  NOT NULL,
    [prenom_ar] nvarchar(max)  NOT NULL,
    [nom_fr] nvarchar(max)  NOT NULL,
    [prenom_fr] nvarchar(max)  NOT NULL,
    [sex] nvarchar(max)  NOT NULL,
    [date_n] datetime  NULL,
    [lieu_n] nvarchar(max)  NOT NULL,
    [adresse] nvarchar(max)  NOT NULL,
    [photo] varbinary(max)  NULL,
    [date_install] datetime  NOT NULL,
    [rank_orgnl] nvarchar(max)  NOT NULL,
    [n_ccp] nvarchar(max)  NOT NULL,
    [n_cnas] nvarchar(max)  NULL,
    [situation_fml] nvarchar(max)  NOT NULL,
    [id_vacance] int  NOT NULL,
    [catgr] nvarchar(max)  NOT NULL,
    [nbr_children] int  NULL,
    [service_nationale] nvarchar(max)  NULL,
    [date_out_work] datetime  NULL,
    [etat_emply] nvarchar(max)  NOT NULL,
    [rotba_id_rotba] int  NOT NULL,
    [branche_id_branche] int  NOT NULL,
    [date_n_bool] bit  NOT NULL,
    [date_n_prisime] int  NULL,
    [prenom_pere] nvarchar(max)  NULL,
    [apc_annex_catgr_id_apc_annex] int  NOT NULL,
    [apc_annex_catgr_detail_id_annex_detail] int  NOT NULL,
    [diplome] nvarchar(max)  NULL,
    [login_id_user] int  NOT NULL
);
GO

-- Creating table 'doc_vacanceSet'
CREATE TABLE [dbo].[doc_vacanceSet] (
    [id_vacnace] int IDENTITY(1,1) NOT NULL,
    [vacance_year] int  NOT NULL,
    [nbr_cons] int  NOT NULL,
    [nbr_rest] int  NOT NULL,
    [date_vac_out] datetime  NOT NULL,
    [date_vac_in] datetime  NOT NULL,
    [nom_interim] nvarchar(max)  NOT NULL,
    [employ_id] int  NOT NULL,
    [place_vac] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'rotbaSet'
CREATE TABLE [dbo].[rotbaSet] (
    [id_rotba] int IDENTITY(1,1) NOT NULL,
    [nom_rotba] nvarchar(max)  NOT NULL,
    [sinf] int  NOT NULL,
    [istidl] int  NOT NULL,
    [silk] nvarchar(max)  NOT NULL,
    [branche_id_branche] int  NOT NULL
);
GO

-- Creating table 'doc_promotionSet'
CREATE TABLE [dbo].[doc_promotionSet] (
    [id_promtion] int IDENTITY(1,1) NOT NULL,
    [n_promtion] int  NOT NULL,
    [date_promtion] datetime  NOT NULL,
    [employ_id] int  NOT NULL,
    [rotba_id_rotba] int  NOT NULL
);
GO

-- Creating table 'doc_ta9yimSet'
CREATE TABLE [dbo].[doc_ta9yimSet] (
    [id_ta9yom] int IDENTITY(1,1) NOT NULL,
    [type_ta9yim] nvarchar(max)  NOT NULL,
    [employ_id] int  NOT NULL,
    [date_ta9yim] datetime  NOT NULL,
    [ta9dir_annee] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'doc_mo7asabaSet'
CREATE TABLE [dbo].[doc_mo7asabaSet] (
    [id_mo7asaba] int IDENTITY(1,1) NOT NULL,
    [nbr_day_absence] int  NOT NULL,
    [date1_abs] datetime  NOT NULL,
    [date2_abs] datetime  NOT NULL,
    [employ_id] int  NOT NULL
);
GO

-- Creating table 'doc_7arakaSet'
CREATE TABLE [dbo].[doc_7arakaSet] (
    [id_7araka] int IDENTITY(1,1) NOT NULL,
    [type_7araka] nvarchar(max)  NOT NULL,
    [date_start_7araka] datetime  NOT NULL,
    [date_fin_7araka] datetime  NULL,
    [employ_id] int  NOT NULL
);
GO

-- Creating table 'doc_displineSet'
CREATE TABLE [dbo].[doc_displineSet] (
    [id_displine] int IDENTITY(1,1) NOT NULL,
    [titre] nvarchar(max)  NOT NULL,
    [n_displine] int  NOT NULL,
    [hokem_9adaii] nvarchar(max)  NOT NULL,
    [date_7okem] datetime  NOT NULL,
    [date_arrete] datetime  NOT NULL,
    [employ_id] int  NOT NULL
);
GO

-- Creating table 'doc_vacane_plusSet'
CREATE TABLE [dbo].[doc_vacane_plusSet] (
    [id_vac_plus] int IDENTITY(1,1) NOT NULL,
    [titre_vacplus] nvarchar(max)  NOT NULL,
    [date_out_vacpus] datetime  NOT NULL,
    [date_in_vacplus] datetime  NOT NULL,
    [employ_id] int  NOT NULL,
    [nbr_day_vac] int  NOT NULL
);
GO

-- Creating table 'doc_morasalt_idariyaSet'
CREATE TABLE [dbo].[doc_morasalt_idariyaSet] (
    [id_morasalt] int IDENTITY(1,1) NOT NULL,
    [titre_morasala] nvarchar(max)  NOT NULL,
    [employ_id] int  NOT NULL,
    [n_morasalt] int  NOT NULL,
    [date_morasalt] datetime  NOT NULL,
    [scan_doc_morsalt] varbinary(max)  NULL
);
GO

-- Creating table 'brancheSet'
CREATE TABLE [dbo].[brancheSet] (
    [id_branche] int IDENTITY(1,1) NOT NULL,
    [nom_branche] nvarchar(max)  NOT NULL,
    [nom_corp] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'doc2_chngmt_darajaSet'
CREATE TABLE [dbo].[doc2_chngmt_darajaSet] (
    [id_chngmnt_daraja] int IDENTITY(1,1) NOT NULL,
    [period_daraja] nvarchar(max)  NOT NULL,
    [valeur_daraja] int  NOT NULL,
    [date_daraja] datetime  NOT NULL,
    [employ_id] int  NOT NULL
);
GO

-- Creating table 'doc2_chngmnt_delgationSet'
CREATE TABLE [dbo].[doc2_chngmnt_delgationSet] (
    [id_chngmnt_delegation] int IDENTITY(1,1) NOT NULL,
    [n_delegation] int  NOT NULL,
    [date_start_delegation] datetime  NOT NULL,
    [date_fin_delegation] datetime  NULL,
    [type_delegation] nvarchar(max)  NOT NULL,
    [employ_id] int  NOT NULL
);
GO

-- Creating table 'doc2_chngmnt_posteSet'
CREATE TABLE [dbo].[doc2_chngmnt_posteSet] (
    [id_chngmnt_poste] int IDENTITY(1,1) NOT NULL,
    [n_chngmnt_poste] int  NOT NULL,
    [new_nomination_poste] nvarchar(max)  NOT NULL,
    [date_start_nomination] datetime  NOT NULL,
    [date_fin_nomination] datetime  NULL,
    [employ_id] int  NOT NULL
);
GO

-- Creating table 'doc2_charge_poste'
CREATE TABLE [dbo].[doc2_charge_poste] (
    [id_charge] int IDENTITY(1,1) NOT NULL,
    [n_9arar_charge] int  NOT NULL,
    [date_start_charge] datetime  NOT NULL,
    [date_fin_charge] datetime  NULL,
    [employ_id] int  NOT NULL,
    [apc_annex_catgr_id_apc_annex] int  NOT NULL,
    [apc_annex_catgr_detail_id_annex_detail] int  NOT NULL
);
GO

-- Creating table 'apc_annex_catgr'
CREATE TABLE [dbo].[apc_annex_catgr] (
    [id_apc_annex] int IDENTITY(1,1) NOT NULL,
    [nom_apc_annex] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'apc_annex_catgr_detail'
CREATE TABLE [dbo].[apc_annex_catgr_detail] (
    [id_annex_detail] int IDENTITY(1,1) NOT NULL,
    [nom_annex_detail] nvarchar(max)  NOT NULL,
    [apc_annex_catgr_id_apc_annex] int  NOT NULL
);
GO

-- Creating table 'logins'
CREATE TABLE [dbo].[logins] (
    [id_user] int IDENTITY(1,1) NOT NULL,
    [user_name] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [permision_login] int  NOT NULL
);
GO

-- Creating table 'lieu_nominaiton'
CREATE TABLE [dbo].[lieu_nominaiton] (
    [id_lieu_nomination] int IDENTITY(1,1) NOT NULL,
    [date_change_lieu_nomination] datetime  NOT NULL,
    [employ_id] int  NOT NULL,
    [apc_annex_catgr_id_apc_annex] int  NOT NULL,
    [apc_annex_catgr_detail_id_annex_detail] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'employSet'
ALTER TABLE [dbo].[employSet]
ADD CONSTRAINT [PK_employSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id_vacnace] in table 'doc_vacanceSet'
ALTER TABLE [dbo].[doc_vacanceSet]
ADD CONSTRAINT [PK_doc_vacanceSet]
    PRIMARY KEY CLUSTERED ([id_vacnace] ASC);
GO

-- Creating primary key on [id_rotba] in table 'rotbaSet'
ALTER TABLE [dbo].[rotbaSet]
ADD CONSTRAINT [PK_rotbaSet]
    PRIMARY KEY CLUSTERED ([id_rotba] ASC);
GO

-- Creating primary key on [id_promtion] in table 'doc_promotionSet'
ALTER TABLE [dbo].[doc_promotionSet]
ADD CONSTRAINT [PK_doc_promotionSet]
    PRIMARY KEY CLUSTERED ([id_promtion] ASC);
GO

-- Creating primary key on [id_ta9yom] in table 'doc_ta9yimSet'
ALTER TABLE [dbo].[doc_ta9yimSet]
ADD CONSTRAINT [PK_doc_ta9yimSet]
    PRIMARY KEY CLUSTERED ([id_ta9yom] ASC);
GO

-- Creating primary key on [id_mo7asaba] in table 'doc_mo7asabaSet'
ALTER TABLE [dbo].[doc_mo7asabaSet]
ADD CONSTRAINT [PK_doc_mo7asabaSet]
    PRIMARY KEY CLUSTERED ([id_mo7asaba] ASC);
GO

-- Creating primary key on [id_7araka] in table 'doc_7arakaSet'
ALTER TABLE [dbo].[doc_7arakaSet]
ADD CONSTRAINT [PK_doc_7arakaSet]
    PRIMARY KEY CLUSTERED ([id_7araka] ASC);
GO

-- Creating primary key on [id_displine] in table 'doc_displineSet'
ALTER TABLE [dbo].[doc_displineSet]
ADD CONSTRAINT [PK_doc_displineSet]
    PRIMARY KEY CLUSTERED ([id_displine] ASC);
GO

-- Creating primary key on [id_vac_plus] in table 'doc_vacane_plusSet'
ALTER TABLE [dbo].[doc_vacane_plusSet]
ADD CONSTRAINT [PK_doc_vacane_plusSet]
    PRIMARY KEY CLUSTERED ([id_vac_plus] ASC);
GO

-- Creating primary key on [id_morasalt] in table 'doc_morasalt_idariyaSet'
ALTER TABLE [dbo].[doc_morasalt_idariyaSet]
ADD CONSTRAINT [PK_doc_morasalt_idariyaSet]
    PRIMARY KEY CLUSTERED ([id_morasalt] ASC);
GO

-- Creating primary key on [id_branche] in table 'brancheSet'
ALTER TABLE [dbo].[brancheSet]
ADD CONSTRAINT [PK_brancheSet]
    PRIMARY KEY CLUSTERED ([id_branche] ASC);
GO

-- Creating primary key on [id_chngmnt_daraja] in table 'doc2_chngmt_darajaSet'
ALTER TABLE [dbo].[doc2_chngmt_darajaSet]
ADD CONSTRAINT [PK_doc2_chngmt_darajaSet]
    PRIMARY KEY CLUSTERED ([id_chngmnt_daraja] ASC);
GO

-- Creating primary key on [id_chngmnt_delegation] in table 'doc2_chngmnt_delgationSet'
ALTER TABLE [dbo].[doc2_chngmnt_delgationSet]
ADD CONSTRAINT [PK_doc2_chngmnt_delgationSet]
    PRIMARY KEY CLUSTERED ([id_chngmnt_delegation] ASC);
GO

-- Creating primary key on [id_chngmnt_poste] in table 'doc2_chngmnt_posteSet'
ALTER TABLE [dbo].[doc2_chngmnt_posteSet]
ADD CONSTRAINT [PK_doc2_chngmnt_posteSet]
    PRIMARY KEY CLUSTERED ([id_chngmnt_poste] ASC);
GO

-- Creating primary key on [id_charge] in table 'doc2_charge_poste'
ALTER TABLE [dbo].[doc2_charge_poste]
ADD CONSTRAINT [PK_doc2_charge_poste]
    PRIMARY KEY CLUSTERED ([id_charge] ASC);
GO

-- Creating primary key on [id_apc_annex] in table 'apc_annex_catgr'
ALTER TABLE [dbo].[apc_annex_catgr]
ADD CONSTRAINT [PK_apc_annex_catgr]
    PRIMARY KEY CLUSTERED ([id_apc_annex] ASC);
GO

-- Creating primary key on [id_annex_detail] in table 'apc_annex_catgr_detail'
ALTER TABLE [dbo].[apc_annex_catgr_detail]
ADD CONSTRAINT [PK_apc_annex_catgr_detail]
    PRIMARY KEY CLUSTERED ([id_annex_detail] ASC);
GO

-- Creating primary key on [id_user] in table 'logins'
ALTER TABLE [dbo].[logins]
ADD CONSTRAINT [PK_logins]
    PRIMARY KEY CLUSTERED ([id_user] ASC);
GO

-- Creating primary key on [id_lieu_nomination] in table 'lieu_nominaiton'
ALTER TABLE [dbo].[lieu_nominaiton]
ADD CONSTRAINT [PK_lieu_nominaiton]
    PRIMARY KEY CLUSTERED ([id_lieu_nomination] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [employ_id] in table 'doc_vacanceSet'
ALTER TABLE [dbo].[doc_vacanceSet]
ADD CONSTRAINT [FK_employdoc_vacance]
    FOREIGN KEY ([employ_id])
    REFERENCES [dbo].[employSet]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_employdoc_vacance'
CREATE INDEX [IX_FK_employdoc_vacance]
ON [dbo].[doc_vacanceSet]
    ([employ_id]);
GO

-- Creating foreign key on [employ_id] in table 'doc_promotionSet'
ALTER TABLE [dbo].[doc_promotionSet]
ADD CONSTRAINT [FK_employdoc_promotion]
    FOREIGN KEY ([employ_id])
    REFERENCES [dbo].[employSet]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_employdoc_promotion'
CREATE INDEX [IX_FK_employdoc_promotion]
ON [dbo].[doc_promotionSet]
    ([employ_id]);
GO

-- Creating foreign key on [employ_id] in table 'doc_ta9yimSet'
ALTER TABLE [dbo].[doc_ta9yimSet]
ADD CONSTRAINT [FK_employdoc_ta9yim]
    FOREIGN KEY ([employ_id])
    REFERENCES [dbo].[employSet]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_employdoc_ta9yim'
CREATE INDEX [IX_FK_employdoc_ta9yim]
ON [dbo].[doc_ta9yimSet]
    ([employ_id]);
GO

-- Creating foreign key on [employ_id] in table 'doc_displineSet'
ALTER TABLE [dbo].[doc_displineSet]
ADD CONSTRAINT [FK_employdoc_displine]
    FOREIGN KEY ([employ_id])
    REFERENCES [dbo].[employSet]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_employdoc_displine'
CREATE INDEX [IX_FK_employdoc_displine]
ON [dbo].[doc_displineSet]
    ([employ_id]);
GO

-- Creating foreign key on [employ_id] in table 'doc_7arakaSet'
ALTER TABLE [dbo].[doc_7arakaSet]
ADD CONSTRAINT [FK_employdoc_7araka]
    FOREIGN KEY ([employ_id])
    REFERENCES [dbo].[employSet]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_employdoc_7araka'
CREATE INDEX [IX_FK_employdoc_7araka]
ON [dbo].[doc_7arakaSet]
    ([employ_id]);
GO

-- Creating foreign key on [employ_id] in table 'doc_vacane_plusSet'
ALTER TABLE [dbo].[doc_vacane_plusSet]
ADD CONSTRAINT [FK_employdoc_vacane_plus]
    FOREIGN KEY ([employ_id])
    REFERENCES [dbo].[employSet]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_employdoc_vacane_plus'
CREATE INDEX [IX_FK_employdoc_vacane_plus]
ON [dbo].[doc_vacane_plusSet]
    ([employ_id]);
GO

-- Creating foreign key on [employ_id] in table 'doc_morasalt_idariyaSet'
ALTER TABLE [dbo].[doc_morasalt_idariyaSet]
ADD CONSTRAINT [FK_employdoc_morasalt_idariya]
    FOREIGN KEY ([employ_id])
    REFERENCES [dbo].[employSet]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_employdoc_morasalt_idariya'
CREATE INDEX [IX_FK_employdoc_morasalt_idariya]
ON [dbo].[doc_morasalt_idariyaSet]
    ([employ_id]);
GO

-- Creating foreign key on [employ_id] in table 'doc_mo7asabaSet'
ALTER TABLE [dbo].[doc_mo7asabaSet]
ADD CONSTRAINT [FK_employdoc_mo7asaba]
    FOREIGN KEY ([employ_id])
    REFERENCES [dbo].[employSet]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_employdoc_mo7asaba'
CREATE INDEX [IX_FK_employdoc_mo7asaba]
ON [dbo].[doc_mo7asabaSet]
    ([employ_id]);
GO

-- Creating foreign key on [rotba_id_rotba] in table 'employSet'
ALTER TABLE [dbo].[employSet]
ADD CONSTRAINT [FK_rotbaemploy]
    FOREIGN KEY ([rotba_id_rotba])
    REFERENCES [dbo].[rotbaSet]
        ([id_rotba])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_rotbaemploy'
CREATE INDEX [IX_FK_rotbaemploy]
ON [dbo].[employSet]
    ([rotba_id_rotba]);
GO

-- Creating foreign key on [branche_id_branche] in table 'employSet'
ALTER TABLE [dbo].[employSet]
ADD CONSTRAINT [FK_brancheemploy]
    FOREIGN KEY ([branche_id_branche])
    REFERENCES [dbo].[brancheSet]
        ([id_branche])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_brancheemploy'
CREATE INDEX [IX_FK_brancheemploy]
ON [dbo].[employSet]
    ([branche_id_branche]);
GO

-- Creating foreign key on [branche_id_branche] in table 'rotbaSet'
ALTER TABLE [dbo].[rotbaSet]
ADD CONSTRAINT [FK_brancherotba]
    FOREIGN KEY ([branche_id_branche])
    REFERENCES [dbo].[brancheSet]
        ([id_branche])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_brancherotba'
CREATE INDEX [IX_FK_brancherotba]
ON [dbo].[rotbaSet]
    ([branche_id_branche]);
GO

-- Creating foreign key on [employ_id] in table 'doc2_chngmnt_posteSet'
ALTER TABLE [dbo].[doc2_chngmnt_posteSet]
ADD CONSTRAINT [FK_employdoc2_chngmnt_poste]
    FOREIGN KEY ([employ_id])
    REFERENCES [dbo].[employSet]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_employdoc2_chngmnt_poste'
CREATE INDEX [IX_FK_employdoc2_chngmnt_poste]
ON [dbo].[doc2_chngmnt_posteSet]
    ([employ_id]);
GO

-- Creating foreign key on [employ_id] in table 'doc2_chngmt_darajaSet'
ALTER TABLE [dbo].[doc2_chngmt_darajaSet]
ADD CONSTRAINT [FK_employdoc2_chngmt_daraja]
    FOREIGN KEY ([employ_id])
    REFERENCES [dbo].[employSet]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_employdoc2_chngmt_daraja'
CREATE INDEX [IX_FK_employdoc2_chngmt_daraja]
ON [dbo].[doc2_chngmt_darajaSet]
    ([employ_id]);
GO

-- Creating foreign key on [employ_id] in table 'doc2_chngmnt_delgationSet'
ALTER TABLE [dbo].[doc2_chngmnt_delgationSet]
ADD CONSTRAINT [FK_employdoc2_chngmnt_delgation]
    FOREIGN KEY ([employ_id])
    REFERENCES [dbo].[employSet]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_employdoc2_chngmnt_delgation'
CREATE INDEX [IX_FK_employdoc2_chngmnt_delgation]
ON [dbo].[doc2_chngmnt_delgationSet]
    ([employ_id]);
GO

-- Creating foreign key on [employ_id] in table 'doc2_charge_poste'
ALTER TABLE [dbo].[doc2_charge_poste]
ADD CONSTRAINT [FK_employdoc2_charge_poste]
    FOREIGN KEY ([employ_id])
    REFERENCES [dbo].[employSet]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_employdoc2_charge_poste'
CREATE INDEX [IX_FK_employdoc2_charge_poste]
ON [dbo].[doc2_charge_poste]
    ([employ_id]);
GO

-- Creating foreign key on [apc_annex_catgr_id_apc_annex] in table 'apc_annex_catgr_detail'
ALTER TABLE [dbo].[apc_annex_catgr_detail]
ADD CONSTRAINT [FK_apc_annex_catgrapc_annex_catgr_detail]
    FOREIGN KEY ([apc_annex_catgr_id_apc_annex])
    REFERENCES [dbo].[apc_annex_catgr]
        ([id_apc_annex])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_apc_annex_catgrapc_annex_catgr_detail'
CREATE INDEX [IX_FK_apc_annex_catgrapc_annex_catgr_detail]
ON [dbo].[apc_annex_catgr_detail]
    ([apc_annex_catgr_id_apc_annex]);
GO

-- Creating foreign key on [apc_annex_catgr_id_apc_annex] in table 'employSet'
ALTER TABLE [dbo].[employSet]
ADD CONSTRAINT [FK_apc_annex_catgremploy]
    FOREIGN KEY ([apc_annex_catgr_id_apc_annex])
    REFERENCES [dbo].[apc_annex_catgr]
        ([id_apc_annex])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_apc_annex_catgremploy'
CREATE INDEX [IX_FK_apc_annex_catgremploy]
ON [dbo].[employSet]
    ([apc_annex_catgr_id_apc_annex]);
GO

-- Creating foreign key on [apc_annex_catgr_detail_id_annex_detail] in table 'employSet'
ALTER TABLE [dbo].[employSet]
ADD CONSTRAINT [FK_apc_annex_catgr_detailemploy]
    FOREIGN KEY ([apc_annex_catgr_detail_id_annex_detail])
    REFERENCES [dbo].[apc_annex_catgr_detail]
        ([id_annex_detail])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_apc_annex_catgr_detailemploy'
CREATE INDEX [IX_FK_apc_annex_catgr_detailemploy]
ON [dbo].[employSet]
    ([apc_annex_catgr_detail_id_annex_detail]);
GO

-- Creating foreign key on [apc_annex_catgr_id_apc_annex] in table 'doc2_charge_poste'
ALTER TABLE [dbo].[doc2_charge_poste]
ADD CONSTRAINT [FK_apc_annex_catgrdoc2_charge_poste]
    FOREIGN KEY ([apc_annex_catgr_id_apc_annex])
    REFERENCES [dbo].[apc_annex_catgr]
        ([id_apc_annex])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_apc_annex_catgrdoc2_charge_poste'
CREATE INDEX [IX_FK_apc_annex_catgrdoc2_charge_poste]
ON [dbo].[doc2_charge_poste]
    ([apc_annex_catgr_id_apc_annex]);
GO

-- Creating foreign key on [apc_annex_catgr_detail_id_annex_detail] in table 'doc2_charge_poste'
ALTER TABLE [dbo].[doc2_charge_poste]
ADD CONSTRAINT [FK_apc_annex_catgr_detaildoc2_charge_poste]
    FOREIGN KEY ([apc_annex_catgr_detail_id_annex_detail])
    REFERENCES [dbo].[apc_annex_catgr_detail]
        ([id_annex_detail])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_apc_annex_catgr_detaildoc2_charge_poste'
CREATE INDEX [IX_FK_apc_annex_catgr_detaildoc2_charge_poste]
ON [dbo].[doc2_charge_poste]
    ([apc_annex_catgr_detail_id_annex_detail]);
GO

-- Creating foreign key on [rotba_id_rotba] in table 'doc_promotionSet'
ALTER TABLE [dbo].[doc_promotionSet]
ADD CONSTRAINT [FK_rotbadoc_promotion]
    FOREIGN KEY ([rotba_id_rotba])
    REFERENCES [dbo].[rotbaSet]
        ([id_rotba])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_rotbadoc_promotion'
CREATE INDEX [IX_FK_rotbadoc_promotion]
ON [dbo].[doc_promotionSet]
    ([rotba_id_rotba]);
GO

-- Creating foreign key on [login_id_user] in table 'employSet'
ALTER TABLE [dbo].[employSet]
ADD CONSTRAINT [FK_loginemploy]
    FOREIGN KEY ([login_id_user])
    REFERENCES [dbo].[logins]
        ([id_user])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_loginemploy'
CREATE INDEX [IX_FK_loginemploy]
ON [dbo].[employSet]
    ([login_id_user]);
GO

-- Creating foreign key on [employ_id] in table 'lieu_nominaiton'
ALTER TABLE [dbo].[lieu_nominaiton]
ADD CONSTRAINT [FK_employlieu_nominaiton]
    FOREIGN KEY ([employ_id])
    REFERENCES [dbo].[employSet]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_employlieu_nominaiton'
CREATE INDEX [IX_FK_employlieu_nominaiton]
ON [dbo].[lieu_nominaiton]
    ([employ_id]);
GO

-- Creating foreign key on [apc_annex_catgr_id_apc_annex] in table 'lieu_nominaiton'
ALTER TABLE [dbo].[lieu_nominaiton]
ADD CONSTRAINT [FK_apc_annex_catgrlieu_nominaiton]
    FOREIGN KEY ([apc_annex_catgr_id_apc_annex])
    REFERENCES [dbo].[apc_annex_catgr]
        ([id_apc_annex])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_apc_annex_catgrlieu_nominaiton'
CREATE INDEX [IX_FK_apc_annex_catgrlieu_nominaiton]
ON [dbo].[lieu_nominaiton]
    ([apc_annex_catgr_id_apc_annex]);
GO

-- Creating foreign key on [apc_annex_catgr_detail_id_annex_detail] in table 'lieu_nominaiton'
ALTER TABLE [dbo].[lieu_nominaiton]
ADD CONSTRAINT [FK_apc_annex_catgr_detaillieu_nominaiton]
    FOREIGN KEY ([apc_annex_catgr_detail_id_annex_detail])
    REFERENCES [dbo].[apc_annex_catgr_detail]
        ([id_annex_detail])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_apc_annex_catgr_detaillieu_nominaiton'
CREATE INDEX [IX_FK_apc_annex_catgr_detaillieu_nominaiton]
ON [dbo].[lieu_nominaiton]
    ([apc_annex_catgr_detail_id_annex_detail]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------