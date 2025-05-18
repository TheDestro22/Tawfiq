if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CAN_DO') and o.name = 'FK_CAN_DO_CAN_DO_TASK')
alter table CAN_DO
   drop constraint FK_CAN_DO_CAN_DO_TASK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CAN_DO') and o.name = 'FK_CAN_DO_CAN_DO_WORKER')
alter table CAN_DO
   drop constraint FK_CAN_DO_CAN_DO_WORKER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EXPERIENCE') and o.name = 'FK_EXPERIEN_RELATIONS_WORKER')
alter table EXPERIENCE
   drop constraint FK_EXPERIEN_RELATIONS_WORKER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EXPERIENCE') and o.name = 'FK_EXPERIEN_RELATIONS_WORKER_S')
alter table EXPERIENCE
   drop constraint FK_EXPERIEN_RELATIONS_WORKER_S
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FEEDBACK') and o.name = 'FK_FEEDBACK_C_GIVES_CLIENT')
alter table FEEDBACK
   drop constraint FK_FEEDBACK_C_GIVES_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FEEDBACK') and o.name = 'FK_FEEDBACK_FB_OF_REQUEST')
alter table FEEDBACK
   drop constraint FK_FEEDBACK_FB_OF_REQUEST
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FEEDBACK') and o.name = 'FK_FEEDBACK_W_GIVES_WORKER')
alter table FEEDBACK
   drop constraint FK_FEEDBACK_W_GIVES_WORKER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REQUEST') and o.name = 'FK_REQUEST_REQUESTS_CLIENT')
alter table REQUEST
   drop constraint FK_REQUEST_REQUESTS_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REQUEST') and o.name = 'FK_REQUEST_REQUESTS_TASK')
alter table REQUEST
   drop constraint FK_REQUEST_REQUESTS_TASK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REQUIRES') and o.name = 'FK_REQUIRES_REQUIRES_TASK')
alter table REQUIRES
   drop constraint FK_REQUIRES_REQUIRES_TASK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REQUIRES') and o.name = 'FK_REQUIRES_REQUIRES_WORKER_S')
alter table REQUIRES
   drop constraint FK_REQUIRES_REQUIRES_WORKER_S
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TIME_SLOT') and o.name = 'FK_TIME_SLO_WORKS_AT_WORKER')
alter table TIME_SLOT
   drop constraint FK_TIME_SLO_WORKS_AT_WORKER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('WORKER_LOCATION') and o.name = 'FK_WORKER_L_WORKS_IN_WORKER')
alter table WORKER_LOCATION
   drop constraint FK_WORKER_L_WORKS_IN_WORKER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CAN_DO')
            and   name  = 'CAN_DO_FK2'
            and   indid > 0
            and   indid < 255)
   drop index CAN_DO.CAN_DO_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CAN_DO')
            and   name  = 'CAN_DO_FK'
            and   indid > 0
            and   indid < 255)
   drop index CAN_DO.CAN_DO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CAN_DO')
            and   type = 'U')
   drop table CAN_DO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENT')
            and   type = 'U')
   drop table CLIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EXPERIENCE')
            and   name  = 'RELATIONSHIP_5_FK'
            and   indid > 0
            and   indid < 255)
   drop index EXPERIENCE.RELATIONSHIP_5_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EXPERIENCE')
            and   name  = 'RELATIONSHIP_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index EXPERIENCE.RELATIONSHIP_4_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EXPERIENCE')
            and   type = 'U')
   drop table EXPERIENCE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FEEDBACK')
            and   name  = 'C_GIVES_FK'
            and   indid > 0
            and   indid < 255)
   drop index FEEDBACK.C_GIVES_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FEEDBACK')
            and   name  = 'FB_OF_FK'
            and   indid > 0
            and   indid < 255)
   drop index FEEDBACK.FB_OF_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FEEDBACK')
            and   type = 'U')
   drop table FEEDBACK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REQUEST')
            and   name  = 'REQUESTS_FK2'
            and   indid > 0
            and   indid < 255)
   drop index REQUEST.REQUESTS_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REQUEST')
            and   name  = 'REQUESTS_FK'
            and   indid > 0
            and   indid < 255)
   drop index REQUEST.REQUESTS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REQUEST')
            and   type = 'U')
   drop table REQUEST
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REQUIRES')
            and   name  = 'REQUIRES_FK2'
            and   indid > 0
            and   indid < 255)
   drop index REQUIRES.REQUIRES_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REQUIRES')
            and   name  = 'REQUIRES_FK'
            and   indid > 0
            and   indid < 255)
   drop index REQUIRES.REQUIRES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REQUIRES')
            and   type = 'U')
   drop table REQUIRES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TASK')
            and   type = 'U')
   drop table TASK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TIME_SLOT')
            and   name  = 'WORKS_AT_FK'
            and   indid > 0
            and   indid < 255)
   drop index TIME_SLOT.WORKS_AT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIME_SLOT')
            and   type = 'U')
   drop table TIME_SLOT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('WORKER')
            and   name  = 'W_GIVES_FK'
            and   indid > 0
            and   indid < 255)
   drop index WORKER.W_GIVES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('WORKER')
            and   type = 'U')
   drop table WORKER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('WORKER_LOCATION')
            and   name  = 'WORKS_IN_FK'
            and   indid > 0
            and   indid < 255)
   drop index WORKER_LOCATION.WORKS_IN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('WORKER_LOCATION')
            and   type = 'U')
   drop table WORKER_LOCATION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('WORKER_SPECIALTY')
            and   type = 'U')
   drop table WORKER_SPECIALTY
go

/*==============================================================*/
/* Table: CAN_DO                                                */
/*==============================================================*/
create table CAN_DO (
   TASK_ID              int                  not null,
   WORKER_ID            int                  not null,
   constraint PK_CAN_DO primary key (TASK_ID, WORKER_ID)
)
go

/*==============================================================*/
/* Index: CAN_DO_FK                                             */
/*==============================================================*/
create index CAN_DO_FK on CAN_DO (
TASK_ID ASC
)
go

/*==============================================================*/
/* Index: CAN_DO_FK2                                            */
/*==============================================================*/
create index CAN_DO_FK2 on CAN_DO (
WORKER_ID ASC
)
go

/*==============================================================*/
/* Table: CLIENT                                                */
/*==============================================================*/
create table CLIENT (
   CLIENT_ID            int                  not null,
   NAME                 varchar(50)          null,
   PHONE                varchar(13)          null,
   ADDRESS              varchar(50)          null,
   EMAIL                varchar(50)          null,
   PAYMENT_INFO         varchar(255)         null,
   OVERALL              decimal(3,2)         null,
   constraint PK_CLIENT primary key nonclustered (CLIENT_ID)
)
go

/*==============================================================*/
/* Table: EXPERIENCE                                            */
/*==============================================================*/
create table EXPERIENCE (
   WORKER_ID            int                  not null,
   SPECIALTY_ID         int                  not null,
   YEAR                 int                  null,
   constraint PK_EXPERIENCE primary key (WORKER_ID, SPECIALTY_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_4_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_4_FK on EXPERIENCE (
WORKER_ID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_5_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_5_FK on EXPERIENCE (
SPECIALTY_ID ASC
)
go

/*==============================================================*/
/* Table: FEEDBACK                                              */
/*==============================================================*/
create table FEEDBACK (
   CLIENT_ID            int                  not null,
   WORKER_ID            int                  not null,
   REQUEST_ID           int                  not null,
   FROM_CLIENT          bit                  not null,
   COMMENT              varchar(Max)         null,
   RATING               dec(3,2)             null,
   constraint PK_FEEDBACK primary key (CLIENT_ID, WORKER_ID, REQUEST_ID, FROM_CLIENT)
)
go

/*==============================================================*/
/* Index: FB_OF_FK                                              */
/*==============================================================*/
create index FB_OF_FK on FEEDBACK (
REQUEST_ID ASC
)
go

/*==============================================================*/
/* Index: C_GIVES_FK                                            */
/*==============================================================*/
create index C_GIVES_FK on FEEDBACK (
CLIENT_ID ASC
)
go

/*==============================================================*/
/* Table: REQUEST                                               */
/*==============================================================*/
create table REQUEST (
   REQUEST_ID           int                  not null,
   TASK_ID              int                  not null,
   CLIENT_ID            int                  not null,
   REQUEST_TIME         timestamp            null,
   REQUEST_ADDRESS      varchar(50)          null,
   REQUEST_STATUS       varchar(10)          null default 'Pending',
   PREFERRED_TIME_SLOT  varchar(30)          null,
   ACTUAL_TIME_TAKEN    decimal(3,2)         null,
   constraint PK_REQUEST primary key nonclustered (REQUEST_ID)
)
go

/*==============================================================*/
/* Index: REQUESTS_FK                                           */
/*==============================================================*/
create index REQUESTS_FK on REQUEST (
CLIENT_ID ASC
)
go

/*==============================================================*/
/* Index: REQUESTS_FK2                                          */
/*==============================================================*/
create index REQUESTS_FK2 on REQUEST (
TASK_ID ASC
)
go

/*==============================================================*/
/* Table: REQUIRES                                              */
/*==============================================================*/
create table REQUIRES (
   TASK_ID              int                  not null,
   SPECIALTY_ID         int                  not null,
   constraint PK_REQUIRES primary key (TASK_ID, SPECIALTY_ID)
)
go

/*==============================================================*/
/* Index: REQUIRES_FK                                           */
/*==============================================================*/
create index REQUIRES_FK on REQUIRES (
TASK_ID ASC
)
go

/*==============================================================*/
/* Index: REQUIRES_FK2                                          */
/*==============================================================*/
create index REQUIRES_FK2 on REQUIRES (
SPECIALTY_ID ASC
)
go

/*==============================================================*/
/* Table: TASK                                                  */
/*==============================================================*/
create table TASK (
   TASK_ID              int                  not null,
   TASK_NAME            varchar(50)          null,
   REQUIRED_SPECIALITY  varchar(30)          null,
   AVERAGE_TIME         decimal(3,2)         null default 0.00,
   AVERAGE_FEE          decimal(3,2)         null default 0.00,
   constraint PK_TASK primary key nonclustered (TASK_ID)
)
go

/*==============================================================*/
/* Table: TIME_SLOT                                             */
/*==============================================================*/
create table TIME_SLOT (
   TIME_SLOT_ID         int                  not null,
   WORKER_ID            int                  not null,
   START_TIME           datetime             null,
   END_TIME             datetime             null,
   DAY                  varchar(10)          null,
   constraint PK_TIME_SLOT primary key nonclustered (TIME_SLOT_ID)
)
go

/*==============================================================*/
/* Index: WORKS_AT_FK                                           */
/*==============================================================*/
create index WORKS_AT_FK on TIME_SLOT (
WORKER_ID ASC
)
go

/*==============================================================*/
/* Table: WORKER                                                */
/*==============================================================*/
create table WORKER (
   WORKER_ID            int                  not null,
   NAME                 varchar(50)          null,
   OVERALL              decimal(3,2)         null,
   constraint PK_WORKER primary key nonclustered (WORKER_ID)
)
go

/*==============================================================*/
/* Index: W_GIVES_FK                                            */
/*==============================================================*/
create index W_GIVES_FK on WORKER (
WORKER_ID ASC
)
go

/*==============================================================*/
/* Table: WORKER_LOCATION                                       */
/*==============================================================*/
create table WORKER_LOCATION (
   LOCATION             varchar(50)          not null,
   WORKER_ID            int                  not null,
   constraint PK_WORKER_LOCATION primary key nonclustered (LOCATION, WORKER_ID)
)
go

/*==============================================================*/
/* Index: WORKS_IN_FK                                           */
/*==============================================================*/
create index WORKS_IN_FK on WORKER_LOCATION (
WORKER_ID ASC
)
go

/*==============================================================*/
/* Table: WORKER_SPECIALTY                                      */
/*==============================================================*/
create table WORKER_SPECIALTY (
   SPECIALTY_ID         int                  not null,
   SPECIALTY            varchar(50)          null,
   constraint PK_WORKER_SPECIALTY primary key nonclustered (SPECIALTY_ID)
)
go

alter table CAN_DO
   add constraint FK_CAN_DO_CAN_DO_TASK foreign key (TASK_ID)
      references TASK (TASK_ID)
go

alter table CAN_DO
   add constraint FK_CAN_DO_CAN_DO_WORKER foreign key (WORKER_ID)
      references WORKER (WORKER_ID)
go

alter table EXPERIENCE
   add constraint FK_EXPERIEN_RELATIONS_WORKER foreign key (WORKER_ID)
      references WORKER (WORKER_ID)
go

alter table EXPERIENCE
   add constraint FK_EXPERIEN_RELATIONS_WORKER_S foreign key (SPECIALTY_ID)
      references WORKER_SPECIALTY (SPECIALTY_ID)
go

alter table FEEDBACK
   add constraint FK_FEEDBACK_C_GIVES_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table FEEDBACK
   add constraint FK_FEEDBACK_FB_OF_REQUEST foreign key (REQUEST_ID)
      references REQUEST (REQUEST_ID)
go

alter table FEEDBACK
   add constraint FK_FEEDBACK_W_GIVES_WORKER foreign key (WORKER_ID)
      references WORKER (WORKER_ID)
go

alter table REQUEST
   add constraint FK_REQUEST_REQUESTS_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table REQUEST
   add constraint FK_REQUEST_REQUESTS_TASK foreign key (TASK_ID)
      references TASK (TASK_ID)
go

alter table REQUIRES
   add constraint FK_REQUIRES_REQUIRES_TASK foreign key (TASK_ID)
      references TASK (TASK_ID)
go

alter table REQUIRES
   add constraint FK_REQUIRES_REQUIRES_WORKER_S foreign key (SPECIALTY_ID)
      references WORKER_SPECIALTY (SPECIALTY_ID)
go

alter table TIME_SLOT
   add constraint FK_TIME_SLO_WORKS_AT_WORKER foreign key (WORKER_ID)
      references WORKER (WORKER_ID)
go

alter table WORKER_LOCATION
   add constraint FK_WORKER_L_WORKS_IN_WORKER foreign key (WORKER_ID)
      references WORKER (WORKER_ID)
go
