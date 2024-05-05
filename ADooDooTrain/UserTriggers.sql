create trigger email_format
before insert on khachhang
for each row
begin
    select case 
		when NEW.Email not like '%_@_%._%' then
			raise(abort, 'Định dạng email không phù hợp: ')
    end;
end;
